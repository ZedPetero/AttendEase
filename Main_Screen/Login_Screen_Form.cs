using AE.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class Login_Screen_Form : Form
    {
        private readonly UserManager<Teacher> _userManager;
        private Dictionary<Control, Point> originalPositions = new();
        private int animationStep = 0;
        private bool isDarkMode = false;

        public Login_Screen_Form(UserManager<Teacher> userManager)
        {
            InitializeComponent();
            _userManager = userManager;
            PrepareControlsForAnimation();
            UIHelper.RoundControl(this, 100);
            UIHelper.RoundControl(btnExit, 50);
            UIHelper.RoundControl(btnLogin, 40);
            UIHelper.RoundControl(txtPassword, 30);
            lblPassword.Text = "";
            lblUsername.Text = "";
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

        private void Login_Screen_Form_Load(object sender, EventArgs e)
        {
            animationStep = 0;
            this.Opacity = 0;
            timerSlide.Start();
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                lblUsername.Text = "Username cannot be empty";
            if (string.IsNullOrEmpty(txtPassword.Text))
                lblPassword.Text = "Password cannot be empty";

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                return;

            try
            {
                var user = await _userManager.FindByNameAsync(txtUsername.Text);

                if (user != null && await _userManager.CheckPasswordAsync(user, txtPassword.Text))
                {
                    MessageBox.Show("Login successful!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    lblUsername.Text = "Invalid username";
                    lblPassword.Text = "Invalid password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (var register = new Register_Screen_Form(_userManager))
            {
                register.ShowDialog();
            }
            this.Show();
            originalPositions.Clear();
            originalPositions = new Dictionary<Control, Point>();
            PrepareControlsForAnimation();
            Login_Screen_Form_Load(sender, e);
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                // Switch to light mode
                isDarkMode = false;
                this.BackColor = Color.White;
                btnDarkMode.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                // Switch to dark mode
                isDarkMode = true;
                this.BackColor = Color.FromArgb(100, 100, 100);
                btnDarkMode.BackColor = Color.FromArgb(80, 80, 80);
            }
        }

        
    }
}
