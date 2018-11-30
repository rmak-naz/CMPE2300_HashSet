using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Diagnostics;

namespace ICA10_HashSet_Profileization
{
    public partial class ICA10_Hashset : Form
    {
        private static CDrawer _canvas = new CDrawer(1000, 1000);
        private static Random _rnd = new Random();
        private HashSet<CTile> _hashTile = new HashSet<CTile>();
        private Stopwatch _sw = new Stopwatch();
        private const int numTile = 40000;

        public ICA10_Hashset()
        {
            InitializeComponent();
        }

        public void Render()
        {
            _canvas.Clear();

            foreach (CTile tile in _hashTile)
                tile.Render(_canvas);

            //_canvas.Render();
        }

        private void B_Populate_Click(object sender, EventArgs e)
        {
            _sw.Start();
            RndPopulate();
            _sw.Stop();
            Console.WriteLine("---------");
            Console.WriteLine("Equals calls: " + CTile._CompCount);
            Console.WriteLine("GetHashCode calls: " + CTile._HashCount);
            Console.WriteLine("Hash list count: " + _hashTile.Count);
            Console.WriteLine("Hash rejected count: " + (numTile - _hashTile.Count).ToString());
            Console.WriteLine("Time elapsed ms: " + _sw.ElapsedMilliseconds);

            Render();
        }

        private void RndPopulate()
        {
            int X = 0, Y = 0;
            for (int tileCount = 0; tileCount < numTile; ++tileCount)
            {
                //Sequential Adds
                if (X > 1000)
                {
                    ++Y;
                    X = 0;
                }
                _hashTile.Add(new CTile(X, Y));
                ++X;

                //Random Adds
                //_hashTile.Add(new CTile(_rnd.Next(0, _canvas.ScaledWidth + 1), _rnd.Next(0, _canvas.ScaledHeight + 1)));
            }

        }
    }
}
