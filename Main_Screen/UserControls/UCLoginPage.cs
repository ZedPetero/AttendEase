using Brevi.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCLoginPage : UserControl
    {
        private readonly UserManager<Teacher> _userManager;
        private readonly string? _prefilledUsername;
        public event EventHandler? GoToSignUpPage;

        public UCLoginPage(UserManager<Teacher> userManager, string? username)
        {
            _userManager = userManager;
            _prefilledUsername = username;
            InitializeComponent();
            if (!string.IsNullOrEmpty(_prefilledUsername))
            {
                txtUsername.Text = _prefilledUsername;
                welcomingLabel.Text = $"Welcome Back, {_prefilledUsername}!";
            }
            UIHelper.RoundControl(panel1, 15);
        }

        public void UCLoginPage_Reset(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            welcomingLabel.Text = "Welcome Back!";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                return;

            try
            {
                var user = await _userManager.FindByNameAsync(txtUsername.Text);

                if (user != null && await _userManager.CheckPasswordAsync(user, txtPassword.Text))
                {
                    UserSession.CurrentTeacherId = user.Id;
                    UserSession.CurrentTeacherName = user.FirstName;
                    MessageBox.Show("Login successful!");
                    this.ParentForm.DialogResult = DialogResult.OK;
                    this.ParentForm.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToSignUpPage?.Invoke(this, EventArgs.Empty);
        }

        private void UCLoginPage_Load(object sender, EventArgs e)
        {
            if (this.FindForm() != null)
            {
                this.FindForm().AcceptButton = btnLogin;
            }
        }
    }
}
