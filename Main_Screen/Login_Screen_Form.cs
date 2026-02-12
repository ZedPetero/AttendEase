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
        private Dictionary<Control, Point> originalPositions = new();
        private int animationStep = 0;

        public Login_Screen_Form()
        {
            InitializeComponent();
            PrepareControlsForAnimation();
            UIHelper.RoundControl(this, 100);
            UIHelper.RoundControl(btnExit, 50);
            UIHelper.RoundControl(sfButton1, 20);
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

        private void sfButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (IsValidUser(username, password))
            {
                // Login successful
                MessageBox.Show(
                    "Login successful!",
                    "Welcome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Example only — replace with DB check later
            return username == "admin" && password == "1234";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
