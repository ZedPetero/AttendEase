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

        }

        private async void PasswordChangebutton_Click(object? sender, EventArgs e)
        {
            string newUsername = UsernameChangetxtbox.Text?.Trim() ?? string.Empty;
            string currentPass = currentPasstxtbox.Text ?? string.Empty;
            string newPass = newPassTxtBox.Text ?? string.Empty;

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(currentPass))
            {
                MessageBox.Show("Please enter your current password to confirm changes.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isChangingPassword = !string.IsNullOrEmpty(newPass);
            if (isChangingPassword && !IsPasswordComplex(newPass))
            {
                MessageBox.Show("New password must contain at least one capital letter, one number, and one non-letter character.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                var isCurrentPassValid = await _userManager.CheckPasswordAsync(user, currentPass);
                if (!isCurrentPassValid)
                {
                    MessageBox.Show("The current password you entered is incorrect.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (user.UserName != newUsername)
                {
                    var existing = await _userManager.FindByNameAsync(newUsername);
                    if (existing != null && existing.Id != user.Id)
                    {
                        MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    user.UserName = newUsername;
                    var userResult = await _userManager.UpdateAsync(user);
                    if (!userResult.Succeeded)
                    {
                        var errors = string.Join("\n", userResult.Errors.Select(x => x.Description));
                        MessageBox.Show($"Failed to update username:\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isChangingPassword)
                {
                    var passResult = await _userManager.ChangePasswordAsync(user, currentPass, newPass);

                    if (passResult.Succeeded)
                    {
                        MessageBox.Show("Profile and password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currentPasstxtbox.Clear();
                        newPassTxtBox.Clear();
                    }
                    else
                    {
                        var errors = string.Join("\n", passResult.Errors.Select(x => x.Description));
                        MessageBox.Show($"Failed to update password:\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UC_Settings_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void saveFormulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validate and Parse inputs
                if (!double.TryParse(PresenttxtBox.Text, out double p) ||
                    !double.TryParse(Latetxtbox.Text, out double l) ||
                    !double.TryParse(Absenttxtbox.Text, out double a) ||
                    !double.TryParse(Excusedtxtbox.Text, out double ex))
                {
                    MessageBox.Show("Please enter valid numbers for all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new AppDbContext())
                {
                    // 2. Find existing settings or create new
                    var settings = db.AttendanceWeights.FirstOrDefault();
                    if (settings == null)
                    {
                        settings = new AttendanceWeights();
                        db.AttendanceWeights.Add(settings);
                    }

                    // 3. Update values
                    settings.PresentWeight = p/100;
                    settings.LateWeight = l/100;
                    settings.AbsentWeight = a/100;
                    settings.ExcusedWeight = ex/100;

                    db.SaveChanges();
                    MessageBox.Show("Formula weights saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
