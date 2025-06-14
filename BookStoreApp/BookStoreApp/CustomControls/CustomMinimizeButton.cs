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
    public partial class CustomMinimizeButton : UserControl
    {
        public CustomMinimizeButton()
        {
            InitializeComponent();

            // Styling the minimize button
            btnMinimize.Text = "➖"; // Minimize icon
            btnMinimize.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.BackColor = Color.DarkGray;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.Dock = DockStyle.Fill; // Make it fill the control

            // Minimize the parent form when clicked
            btnMinimize.Click += (s, e) => {
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.WindowState = FormWindowState.Minimized;
                }
            };


            this.Controls.Add(btnMinimize);
            this.Size = btnMinimize.Size; // Ensure control matches button size
        }

        private void CustomMinimizeButton_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }
    }
}
