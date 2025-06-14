using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    public partial class RegisterForm : Form
    {
        private async Task<bool> RegisterUser(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiBaseUrl = ConfigurationManager.AppSettings["apibaseurl"];
                client.BaseAddress = new Uri(apiBaseUrl);

                var registerData = new { Username = username, Password = password };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(registerData), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("/api/users/register", jsonContent);

                return response.IsSuccessStatusCode;
            }
        }
        public RegisterForm()
        {
            InitializeComponent();
            FormDragger.EnableDrag(this, this);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (await RegisterUser(username, password))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close register form after success
            }
            else
            {
                MessageBox.Show("Registration failed. Username may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
