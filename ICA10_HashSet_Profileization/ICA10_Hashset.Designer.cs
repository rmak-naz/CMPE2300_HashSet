namespace ICA10_HashSet_Profileization
{
    partial class ICA10_Hashset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Populate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Populate
            // 
            this.B_Populate.Location = new System.Drawing.Point(13, 13);
            this.B_Populate.Name = "B_Populate";
            this.B_Populate.Size = new System.Drawing.Size(75, 23);
            this.B_Populate.TabIndex = 0;
            this.B_Populate.Text = "Populate";
            this.B_Populate.UseVisualStyleBackColor = true;
            this.B_Populate.Click += new System.EventHandler(this.B_Populate_Click);
            // 
            // ICA10_Hashset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.B_Populate);
            this.Name = "ICA10_Hashset";
            this.Text = "HashSet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Populate;
    }
}

