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
    public partial class Basket : UserControl
    {
        public Basket()
        {
            InitializeComponent();
            btnBasket.Text = "🛒";
            btnBasket.Font = new Font("Segoe UI", 10);
            btnBasket.BackColor = Color.DarkOrange;
            btnBasket.ForeColor = Color.White;
            btnBasket.FlatStyle = FlatStyle.Flat;
            btnBasket.FlatAppearance.BorderSize = 0;
            btnBasket.Size = new Size(30, 30);
            btnBasket.TextAlign = ContentAlignment.TopLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
