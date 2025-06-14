using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Configuration;


namespace BookStoreApp
{
    public partial class CustomerDashboard : Form
    {
        private int userID;
        private string userName;
        List<ListViewItem> allBooks = new List<ListViewItem>();


        public CustomerDashboard(int id, string username)
        {
            InitializeComponent();
            FormDragger.EnableDrag(this, this);

            txtSearch.Text = "Search books...";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;

            this.userID = id;
            this.userName = username;
            FetchBooksFromApi();
            this.FormClosed += new FormClosedEventHandler(Form_Closed);
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search books...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search books...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewBooks.Items.Clear();
            string searchTerm = txtSearch.Text.ToLower();
            if (searchTerm == "search books...")
            {
                foreach(ListViewItem item in allBooks)
                {
                    listViewBooks.Items.Add((ListViewItem)item.Clone());
                }
                return;
            }

            foreach (ListViewItem item in allBooks) // `allBooks` holds original items
            {
                if (item.SubItems[0].Text.ToLower().Contains(searchTerm))
                {
                    listViewBooks.Items.Add((ListViewItem)item.Clone()); // Add matching items
                }
            }
            listViewBooks.Refresh();
        }
        private async void FetchBooksFromApi()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
            string apiUrl = $"{apiBaseUrl}/api/books";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(apiUrl);
                var jsonData = await response.Content.ReadAsStringAsync();


                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonSerializer.Deserialize<ApiResponse>(jsonData);
                    var books = apiResponse.Values;
                    listViewBooks.Items.Clear();
                    allBooks.Clear();
                    foreach (var book in books)
                    {
                        var item = new ListViewItem(new[] { book.Title, book.Author, book.Price.ToString() });
                        listViewBooks.Items.Add(item);
                        allBooks.Add((ListViewItem)item.Clone());
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to fetch books. Status Code: {response.StatusCode}");
                }
                listViewBooks.Refresh();
                listViewBooks.Update();
            }
        }
    }
}
