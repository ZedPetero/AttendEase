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
    public partial class LoginFormUser : Form
    {
        private readonly UserManager<Teacher> _userManager;

        public LoginFormUser(UserManager<Teacher> userManager)
        {
            _userManager = userManager;
            InitializeComponent();
            UCInteractionPage iPage = new UCInteractionPage();
            iPage.StartNowClicked += (s, e) => LoadForm(new UCSignUpPage(_userManager));
            LoadForm(iPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        public void LoadForm(UserControl customizedControl)
        {
            pnlMainContent.Controls.Clear();

            customizedControl.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(customizedControl);

            customizedControl.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadForm(new UCLoginPage(_userManager));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUp = new UCSignUpPage(_userManager);
            signUp.SignUpComplete += (s, e) => LoadForm(new UCLoginPage(_userManager));
            LoadForm(signUp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new UCInteractionPage());
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            LoadForm(new UCAboutUsPage());
        }
    }
}
