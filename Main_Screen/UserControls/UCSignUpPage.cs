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
    public partial class UCSignUpPage : UserControl
    {
        private readonly UserManager<Teacher> _userManager;
        public event EventHandler? SignUpComplete;

        public UCSignUpPage(UserManager<Teacher> userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher
            {
                UserName = txtUsername.Text,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            var result = await _userManager.CreateAsync(teacher, txtPassword.Text);

            if (result.Succeeded)
            {
                MessageBox.Show("Registration successful! You can now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Go to login page 
                SignUpComplete?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                string errors = string.Join("\n", result.Errors.Select(e => e.Description));
                MessageBox.Show($"Registration failed:\n{errors}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
