using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Brevi.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Brevi.Domain.Models;
using System.Text.RegularExpressions;
using System.Linq;

namespace Brevi.Application
{
    public partial class UCSettings : UserControl
    {
        private readonly UserManager<Teacher> _userManager;

        public UCSettings()
        {
            InitializeComponent();

            // Build minimal service provider to access UserManager
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=AttendEase.db"));

            services.AddIdentityCore<Teacher>()
                .AddEntityFrameworkStores<AppDbContext>();

            var serviceProvider = services.BuildServiceProvider();

            _userManager = (UserManager<Teacher>)serviceProvider.GetService(typeof(UserManager<Teacher>));


            UsernameChangebutton.Click += UsernameChangebutton_Click;
            PasswordChangeButton.Click += PasswordChangeButton_Click;
        }

        private async void UsernameChangebutton_Click(object? sender, EventArgs e)
        {
            var newUsername = UsernameChangetxtbox.Text?.Trim();

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userManager == null)
            {
                MessageBox.Show("User manager is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = await _userManager.FindByIdAsync(UserSession.CurrentTeacherId.ToString());
                if (user == null)
                {
                    MessageBox.Show("Current user not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existing = await _userManager.FindByNameAsync(newUsername);
                if (existing != null && existing.Id != user.Id)
                {
                    MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.UserName = newUsername;
                user.NormalizedUserName = _userManager.NormalizeName(newUsername);

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    MessageBox.Show("Username updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var errors = string.Join("\n", result.Errors.Select(x => x.Description));
                    MessageBox.Show($"Failed to update username:\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPasswordComplex(string pwd)
        {
            if (string.IsNullOrEmpty(pwd)) return false;

            bool hasUpper = pwd.Any(char.IsUpper);
            bool hasDigit = pwd.Any(char.IsDigit);
            bool hasNonLetter = pwd.Any(ch => !char.IsLetter(ch));

            return hasUpper && hasDigit && hasNonLetter;
        }

        private async void PasswordChangeButton_Click(object? sender, EventArgs e)
        {
            var newPassword = PasswordChangetxtbox.Text ?? string.Empty;

            if (!IsPasswordComplex(newPassword))
            {
                MessageBox.Show("Password must contain at least one capital letter, one number, and one non-letter character.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userManager == null)
            {
                MessageBox.Show("User manager is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = await _userManager.FindByIdAsync(UserSession.CurrentTeacherId.ToString());
                if (user == null)
                {
                    MessageBox.Show("Current user not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

                if (result.Succeeded)
                {
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var errors = string.Join("\n", result.Errors.Select(x => x.Description));
                    MessageBox.Show($"Failed to update password:\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.RoundControl(AccountManagementPanel, 20);
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            UIHelper.RoundControl(kryptonPanel1, 20);
        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
