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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Timer = System.Windows.Forms.Timer;

namespace Brevi.Application
{
    public partial class UCInteractionPage : UserControl
    {
        private readonly IUserService _userService;
        public event EventHandler? StartNowClicked;
        public event Action<string>? AccountSelected;
        private Dictionary<Control, Point> originalPositions = new();
        private int animationStep = 0;

        public UCInteractionPage(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            PrepareControlsForAnimation();
            UIHelper.RoundControl(pictureBox1, 10);
            LoadSavedAccounts();
        }

        // Store original positions and set initial state for animation (opacity and offset).

        private void PrepareControlsForAnimation()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.Timer) continue;

                originalPositions[ctrl] = ctrl.Location;
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + 40);
            }
        }

        private void UCInteractionPage_Load(object sender, EventArgs e)
        {
            animationStep = 0;
            timerSlide.Start();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            animationStep++;

            foreach (var pair in originalPositions)
            {
                Control ctrl = pair.Key;
                Point target = pair.Value;

                int newY = ctrl.Location.Y - 4;
                if (newY < target.Y)
                    newY = target.Y;

                ctrl.Location = new Point(ctrl.Location.X, newY);
            }

            if (animationStep >= 15)
            {
                timerSlide.Stop();
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is System.Windows.Forms.Timer) continue;
                    ctrl.Location = originalPositions[ctrl];
                }

                foreach (var pair in originalPositions)
                    pair.Key.Location = pair.Value;
            }
        }

        // Load saved accounts from the user service and create a label for each username in the panel.

        private void LoadSavedAccounts()
        {
            try
            {
                var usernames = _userService.GetAllUsernames() ?? new List<string>();
                // Clear existing controls in the panel and add a label per username so designer can style the panel/list as desired
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
                    lbl.Click += Label_Click; // optional single-click behavior if designer wants to handle selection
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
            // Keep a simple visual selection on single click if desired by designer (does not affect other rows' selection logic).
            // Designers can remove or style this behavior in the designer; we only toggle a simple BackColor here.
            try
            {
                if (sender is Label lbl)
                {
                    // Toggle selection for this label only
                    var selected = lbl.BackColor == SystemColors.Highlight;
                    lbl.BackColor = selected ? SystemColors.Window : SystemColors.Highlight;
                    lbl.ForeColor = selected ? SystemColors.ControlText : SystemColors.HighlightText;
                }
            }
            catch { /* swallow */ }
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
