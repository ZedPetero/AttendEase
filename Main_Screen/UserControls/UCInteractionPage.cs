using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using ReaLTaiizor.Enum.Metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCInteractionPage : UserControl
    {
        private readonly UserManager<Teacher> _userManager;
        public event EventHandler? StartNowClicked;
        public event Action<string>? AccountSelected;

        public UCInteractionPage(UserManager<Teacher> userManager)
        {
            _userManager = userManager;
            InitializeComponent();
            LoadSavedAccounts();
        }

        private void LoadSavedAccounts()
        {
            try
            {
                var usernames = _userManager.Users.Select(u => u.UserName).ToList();
                loggedInViewPanel.Controls.Clear();

                int y = 0;
                int spacing = 2;
                foreach (var username in usernames)
                {
                    if (string.IsNullOrEmpty(username))
                        continue;

                    var lbl = new Label();
                    LabelProperties(lbl, username, y);

                    lbl.DoubleClick += Label_DoubleClick;
                    lbl.Click += Label_Click;
                    loggedInViewPanel.Controls.Add(lbl);

                    y += lbl.Height + spacing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading saved accounts: {ex.Message}");
            }
        }

        public void LabelProperties(Label label, string username, int y)
        {
            label.Text = username;
            label.Tag = username;
            label.Location = new Point(0, y);
            label.AutoSize = false;
            label.Height = 30;
            label.Width = Math.Max(0, loggedInViewPanel.ClientSize.Width - 4);
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Cursor = Cursors.Hand;
            label.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label.Padding = new Padding(4, 0, 0, 0);
            label.Font = new Font("Inter Medium", 10, FontStyle.Regular);
        }

        private void Label_Click(object? sender, EventArgs e)
        {
            try
            {
                if (sender is Label lbl)
                {
                    var selected = lbl.BackColor == Color.FromArgb(39, 165, 153);
                    lbl.BackColor = selected ? SystemColors.Window : Color.FromArgb(39, 165, 153);
                    lbl.ForeColor = selected ? SystemColors.ControlText : Color.White;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Label_DoubleClick(object? sender, EventArgs e)
        {
            try
            {
                if (sender is Label lbl)
                {
                    var username = lbl.Tag as string;
                    if (!string.IsNullOrEmpty(username))
                        AccountSelected?.Invoke(username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting account: {ex.Message}");
            }
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            StartNowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
