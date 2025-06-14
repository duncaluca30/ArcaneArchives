using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BookStoreApp.CustomControls;
using Newtonsoft.Json;

namespace BookStoreApp
{
    public partial class LoginForm : Form
    {
        private async Task<(string Role, int ID, string Username)> AuthenticateUser(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
                client.BaseAddress = new Uri(apiBaseUrl);

                var loginData = new { Username = username, Password = password };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/api/users/login", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"API Response Body: {responseBody}");

                    // Deserialize into UserResponse object
                    var userResponse = JsonConvert.DeserializeObject<UserResponse>(responseBody);
                    return (userResponse.Role, userResponse.ID, userResponse.Username);
                }

                return (null, 0, null); // Return default values on failure
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            FormDragger.EnableDrag(this, this);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var (role, id, userName) = await AuthenticateUser(username, password);

            if (role == "Admin")
            {
                var adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if (role == "Customer")
            {
                CustomerDashboard customerDashboard = new CustomerDashboard(id, userName); // Pass user data
                customerDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
