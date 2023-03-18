using CafeManagement.Application.Contracts.Dtos.UserDtos;
using CafeManagement.Application.Contracts.Services;
using ConnectToAPI.FormHomePages;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectToAPI.FormLogins
{
    public partial class FormLogin : Form
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IUserService _userService;

        private bool _isLoadingDone = false;

        public FormLogin(IMemoryCache memoryCache, IUserService userService)
        {
            InitializeComponent();
            _memoryCache = memoryCache;
            _userService = userService;
        }

        private void BtPageRegister_Click(object sender, EventArgs e)
        {
            var pageRegister = Program.ServiceProvider.GetService<FormRegister>();
            pageRegister.ShowDialog();
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

        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPassword.Checked)
            {
                TbPassword.UseSystemPasswordChar = false;
                CbPassword.Text = "Hide";
            }
            else
            {
                TbPassword.UseSystemPasswordChar = true;
                CbPassword.Text = "View";
            }
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
                try
                {
                    var isValidUser = await _userService.LoginAsync(loginUser);
                    if (isValidUser)
                    {
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