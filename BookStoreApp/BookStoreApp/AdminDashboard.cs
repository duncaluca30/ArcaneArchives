using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Configuration;

namespace BookStoreApp
{
    public partial class AdminDashboard : Form
    {
        List<ListViewItem> allBooks = new List<ListViewItem>();

        public AdminDashboard()
        {
            InitializeComponent();
            FormDragger.EnableDrag(this, this);
            btnUpdateBook.Enabled = false;
            listViewBooks.SelectedIndexChanged += listViewBooks_SelectedIndexChanged;

            txtSearch.Text = "Search books...";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;

            FetchBooksFromApi();
            this.FormClosed += new FormClosedEventHandler(Form_Closed);

            btnAddBook.Click += btnAddBook_Click;
            btnDeleteBook.Click += btnDeleteBook_Click;
            btnUpdateBook.Click += btnUpdateBook_Click;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewBooks.Items.Clear();
            string searchTerm = txtSearch.Text.ToLower();
            if (searchTerm == "search books...")
            {
                foreach (ListViewItem item in allBooks)
                {
                    listViewBooks.Items.Add((ListViewItem)item.Clone());
                }
                return;
            }

            foreach (ListViewItem item in allBooks)
            {
                if (item.SubItems[0].Text.ToLower().Contains(searchTerm))
                {
                    listViewBooks.Items.Add((ListViewItem)item.Clone());
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
        private async System.Threading.Tasks.Task<bool> AddBookToApiAsync(string title, string author, decimal price)
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
            string apiUrl = $"{apiBaseUrl}/api/books/add";

            var newBook = new
            {
                Title = title,
                Author = author,
                Price = price
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonSerializer.Serialize(newBook), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                return response.IsSuccessStatusCode;
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            using (var addBookForm = new AddBook())
            {
                if (addBookForm.ShowDialog() == DialogResult.OK)
                {
                    // Try to add to server first
                    bool success = await AddBookToApiAsync(
                        addBookForm.BookTitle,
                        addBookForm.BookAuthor,
                        addBookForm.BookPrice);

                    if (success)
                    {
                        var item = new ListViewItem(new[]
                        {
                            addBookForm.BookTitle,
                            addBookForm.BookAuthor,
                            addBookForm.BookPrice.ToString("0.00")
                        });

                        listViewBooks.Items.Add(item);
                        allBooks.Add((ListViewItem)item.Clone());
                        listViewBooks.Refresh();
                        MessageBox.Show("Book added to server.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book to server.");
                    }
                }
            }
        }
        private async System.Threading.Tasks.Task<bool> DeleteBookFromApiAsync(string title, string author)
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
            string apiUrl = $"{apiBaseUrl}/api/books/delete";

            var deleteBook = new
            {
                Title = title,
                Author = author
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonSerializer.Serialize(deleteBook), System.Text.Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(apiUrl),
                    Content = content
                };
                HttpResponseMessage response = await client.SendAsync(request);
                return response.IsSuccessStatusCode;
            }
        }
        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count > 0)
            {
                var selectedItem = listViewBooks.SelectedItems[0];
                string title = selectedItem.SubItems[0].Text;
                string author = selectedItem.SubItems[1].Text;

                // Try to delete from server first
                bool success = await DeleteBookFromApiAsync(title, author);

                if (success)
                {
                    // Remove from allBooks
                    allBooks.RemoveAll(item => item.SubItems[0].Text == title &&
                                               item.SubItems[1].Text == author);

                    // Remove from listView
                    listViewBooks.Items.Remove(selectedItem);

                    MessageBox.Show("Book deleted from server.");
                }
                else
                {
                    MessageBox.Show("Failed to delete book from server.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }
        private async System.Threading.Tasks.Task<bool> UpdateBookToApiAsync(
            string oldTitle, string oldAuthor,
            string newTitle, string newAuthor, decimal newPrice)
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
            string apiUrl = $"{apiBaseUrl}/api/books/update"; // Adjust if needed

            var updateBook = new
            {
                OldTitle = oldTitle,
                OldAuthor = oldAuthor,
                NewTitle = newTitle,
                NewAuthor = newAuthor,
                NewPrice = newPrice
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonSerializer.Serialize(updateBook), System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                return response.IsSuccessStatusCode;

            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 0)
                return;

            var selectedItem = listViewBooks.SelectedItems[0];
            string currentTitle = selectedItem.SubItems[0].Text;
            string currentAuthor = selectedItem.SubItems[1].Text;
            decimal currentPrice = decimal.Parse(selectedItem.SubItems[2].Text);

            using (var updateBookForm = new UpdateBook(currentTitle, currentAuthor, currentPrice))
            {
                if (updateBookForm.ShowDialog() == DialogResult.OK)
                {
                    // Update on server first
                    bool success = await UpdateBookToApiAsync(
                        currentTitle, currentAuthor,
                        updateBookForm.BookTitle, updateBookForm.BookAuthor, updateBookForm.BookPrice);

                    if (success)
                    {
                        // Update locally as before
                        selectedItem.SubItems[0].Text = updateBookForm.BookTitle;
                        selectedItem.SubItems[1].Text = updateBookForm.BookAuthor;
                        selectedItem.SubItems[2].Text = updateBookForm.BookPrice.ToString("0.00");

                        var match = allBooks.Find(item =>
                            item.SubItems[0].Text == currentTitle &&
                            item.SubItems[1].Text == currentAuthor &&
                            item.SubItems[2].Text == currentPrice.ToString("0.00"));

                        if (match != null)
                        {
                            match.SubItems[0].Text = updateBookForm.BookTitle;
                            match.SubItems[1].Text = updateBookForm.BookAuthor;
                            match.SubItems[2].Text = updateBookForm.BookPrice.ToString("0.00");
                        }
                        MessageBox.Show("Book modified succesfully");
                        listViewBooks.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update book on server.");
                    }
                }
            }
        }
        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdateBook.Enabled = listViewBooks.SelectedItems.Count > 0;
        }
    }
}