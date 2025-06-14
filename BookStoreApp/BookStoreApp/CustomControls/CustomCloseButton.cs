using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp.CustomControls
{
    public partial class CustomCloseButton : UserControl
    {
        public CustomCloseButton()
        {
            InitializeComponent();

            // Apply custom styling to the Close button
            btnClose.Text = "✖";
            btnClose.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.BackColor = Color.DarkRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Size = new Size(30, 30);
            btnClose.Location = new Point(this.Width - 40, 10);
            btnClose.Padding = new Padding(0, -10, 0, 0);

            this.Size = new Size(30, 30); // Same size as a standard button
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.Transparent;

            btnClose.Click += (s, e) => { this.FindForm()?.Close(); };

        }

        private void CustomCloseButton_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
