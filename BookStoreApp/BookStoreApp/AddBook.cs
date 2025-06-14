using System;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class AddBook : Form
    {
        public string BookTitle => txtTitle.Text.Trim();
        public string BookAuthor => txtAuthor.Text.Trim();
        public decimal BookPrice
        {
            get
            {
                decimal price;
                decimal.TryParse(txtPrice.Text.Trim(), out price);
                return price;
            }
        }

        public AddBook()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            FormDragger.EnableDrag(this, this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BookTitle) ||
                string.IsNullOrWhiteSpace(BookAuthor) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}