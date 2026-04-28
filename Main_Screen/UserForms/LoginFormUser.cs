using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Brevi.Application
{
    public partial class LoginFormUser : Form
    {
        private readonly UserManager<Teacher> _userManager;
        private readonly IUserService _userService;
        private string uName;

        public LoginFormUser(UserManager<Teacher> userManager, IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
            InitializeComponent();
            UCInteractionPage iPage = new UCInteractionPage(_userService);
            iPage.StartNowClicked += (s, e) => btnSignUp_Click(s, e);
            iPage.AccountSelected += (username) => ListForQuickLoginLoad(username);
            LoadForm(iPage);
        }

        private void ListForQuickLoginLoad(string username)
        {
            try
            {
                uName = username;
                var loginPage = new UCLoginPage(_userManager, username);
                loginPage.GoToSignUpPage += (s, e) => btnSignUp_Click(s, e);
                LoadForm(loginPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void LinkEventHandler()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UCLoginPage loginPage = new UCLoginPage(_userManager, uName);
            loginPage.GoToSignUpPage += (s, e) => btnSignUp_Click(s, e);
            loginPage.UCLoginPage_Reset(sender, e);
            LoadForm(loginPage);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var signUp = new UCSignUpPage(_userManager);
            signUp.ToLoginPage += (s, e) => btnLogin_Click(s, e);
            LoadForm(signUp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCInteractionPage iPage = new UCInteractionPage(_userService);
            iPage.StartNowClicked += (s, e) => btnSignUp_Click(s, e);
            iPage.AccountSelected += (username) => ListForQuickLoginLoad(username);
            LoadForm(iPage);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            LoadForm(new UCAboutUsPage());
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kryptonToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (kryptonToggleSwitch1.Checked)
            {
                var darkTheme = darkModePallete;
                ChangeTheme(darkModePallete);
            }
            else
            {
                var lightTheme = lightModePallete;
                ChangeTheme(lightModePallete);
            }
        }

        private void ChangeTheme(Object currentTheme)
        {
            foreach (var control in pnlMainContent.Controls)
            {
                try
                {
                    control.GetType().GetProperty("Palette")?.SetValue(control, currentTheme);
                    control.GetType().GetProperty("ButtonStyle")?.SetValue(control, "Custom_1");
                } catch (Exception e) 
                {
                    MessageBox.Show($"{e.Message} \n {control.GetType().Name}");
                }
            }
        }

    }
}
