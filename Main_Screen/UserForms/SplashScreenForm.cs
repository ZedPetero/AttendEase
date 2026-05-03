using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Brevi.Application
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Splash_Screen_Form_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(30); // adjust radius here

            timer1.Interval = 3500; 
            timer1.Start();
        }
        private void ApplyRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(Width - d, 0, d, d, 270, 90);
            path.AddArc(Width - d, Height - d, d, d, 0, 90);
            path.AddArc(0, Height - d, d, d, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
        private void timer1_Tick(object sender, EventArgs e)
        { 
            timer1.Stop();
            this.Close();  // Close the splash screen
        }
    }
}
