using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA10_HashSet_Profileization
{
    class CTile
    {
        public const int _TileSize = 5;
        private int _X;
        private int _Y;
        public static UInt64 _CompCount { get; private set; }
        public static UInt64 _HashCount { get; private set; }

        public static void ResetStats()
        {
            _CompCount = _HashCount = 0;
        }

        public CTile(int iCol, int iRow)
        {
            if (_TileSize < 2)
                throw new ArgumentException("The tile size must be >= 2");

            _X = iCol;
            _Y = iRow;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is CTile))
                return false;

            ++_CompCount;

            CTile other = (CTile)obj;

            return _X.Equals(other._X) && _Y.Equals(other._Y);
        }

        public override int GetHashCode()
        {
            ++_HashCount;

            return _Y * 1000 + _X;
            //return _X + _Y;
            //return _X * _Y;
            //return 1;
        }

        public void Render(CDrawer dr)
        {
            dr.AddRectangle(_X * _TileSize, _Y * _TileSize, _TileSize - 1, _TileSize - 1, Color.Red);
        }
    }
}
