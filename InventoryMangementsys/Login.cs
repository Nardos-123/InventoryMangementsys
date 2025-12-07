using Datalayer.Data;
using System;
using System.Data.SqlClient;
using System.Net.Http.Json;

namespace InventoryMangementsys
{
    public partial class Login : Form
    {
        private readonly HttpClient _http;
        public Login()
        {
            InitializeComponent();

            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            btnlogin.Click += btnlogin_Click;

            _http = new HttpClient
            {
                BaseAddress = new Uri(" https://localhost:7002/") // your API URL
            };

        }


        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var loginRequest = new
            {
                Username = txtusername.Text.Trim(),
                Password = txtpassword.Text.Trim()
            };

            var response = await _http.PostAsJsonAsync("api/users/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Login Successful!");

                Dashboard main = new Dashboard();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
