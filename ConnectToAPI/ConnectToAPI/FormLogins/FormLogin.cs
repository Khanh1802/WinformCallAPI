using ClassLibrary1.Dtos.Generics;
using ClassLibrary1.Dtos.UserDtos;
using ClassLibrary1.MemoryCacheKeys;
using ConnectToAPI.FormHomePages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;

namespace ConnectToAPI.FormLogins
{
    public partial class FormLogin : Form
    {
        private readonly IMemoryCache _memoryCache;
        private bool _isLoadingDone = false;
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public FormLogin(IMemoryCache memoryCache, HttpClient httpClient, IConfiguration configuration)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            _httpClient = httpClient;
            _configuration = configuration;
        }

        private void BtPageRegister_Click(object sender, EventArgs e)
        {

        }
        private void RefreshPassword()
        {
            TbPassword.UseSystemPasswordChar = true;
            CbPassword.Text = "View";
        }

        private void RefreshTableLogin()
        {
            TbPassword.Text = string.Empty;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            RefreshPassword();
            RefreshTableLogin();
            _isLoadingDone = true;
        }

        private async void BtLogin_Click(object sender, EventArgs e)
        {
            if (_isLoadingDone)
            {
                _isLoadingDone = false;
                if (string.IsNullOrEmpty(TbUserName.Text))
                {
                    MessageBox.Show("User is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isLoadingDone = true;
                    return;
                }
                if (string.IsNullOrEmpty(TbPassword.Text))
                {
                    MessageBox.Show("Password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _isLoadingDone = true;
                    return;
                }
                var loginUser = new LoginUser()
                {
                    UserName = TbUserName.Text,
                    Password = TbPassword.Text,
                };
                var getToken = await _httpClient.PostAsJsonAsync(_configuration["CafeManagement:Login"], loginUser);
                try
                {
                    if (getToken.IsSuccessStatusCode)
                    {
                        var token = (await getToken.Content.ReadFromJsonAsync<Generic<string>>()).Data;
                        _memoryCache.Set(UserCache.UserKey, token);
                        var homePage = Program.ServiceProvider.GetService<FormHomePage>();
                        homePage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _isLoadingDone = true;
            }
        }
    }
}