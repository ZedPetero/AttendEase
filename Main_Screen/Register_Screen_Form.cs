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
        private Dictionary<Control, Point> originalPositions = new();
        private int animationStep = 0;

        public Register_Screen_Form()
        {
            InitializeComponent();
            PrepareControlsForAnimation();
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
    }
}
