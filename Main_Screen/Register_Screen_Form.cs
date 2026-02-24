using AE.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AE.Application
{
    public partial class Register_Screen_Form : Form
    {
        private readonly UserManager<Teacher> _userManager;
        private Dictionary<Control, Point> originalPositions = new();
        private int animationStep = 0;

        public Register_Screen_Form(UserManager<Teacher> userManager)
        {
            InitializeComponent();
            _userManager = userManager;
            PrepareControlsForAnimation();
            UIHelper.RoundControl(this, 100);
            UIHelper.RoundControl(btnExit, 50);
            UIHelper.RoundControl(btnRegister, 40);
        }

        private void Register_Screen_Form_Load(object sender, EventArgs e)
        {
            animationStep = 0;
            this.Opacity = 0;
            timerSlide.Start();
        }

        private void PrepareControlsForAnimation()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.Timer) continue;

                originalPositions[ctrl] = ctrl.Location;

                // Move controls down before showing the form
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + 40);
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            animationStep++;
            this.Opacity += 0.07;

            foreach (var pair in originalPositions)
            {
                Control ctrl = pair.Key;
                Point target = pair.Value;

                int newY = ctrl.Location.Y - 4; // speed
                if (newY < target.Y)
                    newY = target.Y;

                ctrl.Location = new Point(ctrl.Location.X, newY);
            }

            // Stop animation
            if (animationStep >= 15)
            {
                timerSlide.Stop();

                // Snap to exact positions
                foreach (var pair in originalPositions)
                    pair.Key.Location = pair.Value;
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher
            {
                UserName = txtUsername.Text,
                Email = txtEmail.Text,
                FirstName = txtMiddleName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNum.Text
            };


            var result = await _userManager.CreateAsync(teacher, txtPassword.Text);

            if (result.Succeeded)
            {
                MessageBox.Show("Registration successful! You can now log in.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
