﻿using CafeManagement.Application.Contracts.Dtos.UserDtos;
using CafeManagement.Application.Contracts.Dtos.UserTypeDtos;
using CafeManagement.Application.Contracts.Services;

namespace ConnectToAPI.FormLogins
{
    public partial class FormRegister : Form
    {
        private  readonly  IUserTypeService _userTypeService;
        private readonly IUserService _userService;
        private bool _isLoadingDone = false;
        public FormRegister(IUserTypeService userTypeService, IUserService userService)
        {
            _userTypeService = userTypeService;
            _userService = userService;
            InitializeComponent();
        }

        private async void BtRegister_Click(object sender, EventArgs e)
        {
            //if (_isLoadingDone)
            //{
            //    _isLoadingDone = false;
            //    var createUser = new CreateUserDto();

            //    if (CbbUserType.SelectedItem is not UserTypeDto userType)
            //    {
            //        MessageBox.Show("User type is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        _isLoadingDone = true;
            //        return;
            //    }
            //    else
            //    {
            //        createUser.UserTypeId = userType.Id;
            //    }
            //    createUser.FullName = TbFullName.Text.Trim();
            //    createUser.Email = TbEmail.Text.Trim();
            //    createUser.PhoneNumber = TbPhoneNumber.Text.Trim();
            //    createUser.UserName = TbUserName.Text.Trim();
            //    createUser.Password = TbPasswork.Text.Trim();
            //    try
            //    {
            //        createUser.ValidateUser();
            //        await _userService.AddAsync(createUser);
            //        RefreshWhenComplete();
            //        MessageBox.Show("Create USER successfully", "Ok", MessageBoxButtons.OK);
            //        _isLoadingDone = true;
            //        this.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    _isLoadingDone = true;
            //}
        }
        private void BtReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtCheckUserName_Click(object sender, EventArgs e)
        {
            //if (_isLoadingDone)
            //{
            //    _isLoadingDone = false;
            //    if (string.IsNullOrEmpty(TbUserName.Text))
            //    {
            //        MessageBox.Show("Full user name is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        _isLoadingDone = true;
            //        return;
            //    }

            //    var checkUserName = await _userService.CheckUserNameExistAysnc(TbUserName.Text);
            //    if (checkUserName != false)
            //    {
            //        MessageBox.Show("Already exist", "Ok", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Allow", "Ok", MessageBoxButtons.OK);
            //    }
            //    _isLoadingDone = true;
            //}
        }

        private async void FormRegister_Load(object sender, EventArgs e)
        {
            await RefreshComBoBox();
            RefreshHidePass();
            _isLoadingDone = true;
        }

        private async Task RefreshComBoBox()
        {
            //CbbUserType.DataSource = await _userTypeService.GetAllAsync();
            //CbbUserType.DisplayMember = "Name";
        }

        private void RefreshHidePass()
        {
            TbPasswork.UseSystemPasswordChar = true;
            CbPassword.Text = "View";
        }

        private void RefreshWhenComplete()
        {
            RefreshHidePass();
            RefreshTableRegister();
        }

        private void RefreshTableRegister()
        {
            TbFullName.Text = string.Empty;
            TbEmail.Text = string.Empty;
            TbPasswork.Text = string.Empty;
            TbPhoneNumber.Text = string.Empty;
            TbUserName.Text = string.Empty;
        }

        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPassword.Checked)
            {
                TbPasswork.UseSystemPasswordChar = false;
                CbPassword.Text = "Hide";
            }
            else
            {
                TbPasswork.UseSystemPasswordChar = true;
                CbPassword.Text = "View";
            }
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isLoadingDone)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
