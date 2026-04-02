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

        public UCLoginPage(UserManager<Teacher> userManager)
        {
            _userManager = userManager;
            InitializeComponent();
            UIHelper.RoundControl(panel1, 15);
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
    }
}
