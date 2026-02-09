using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Main_Screen
{
    public partial class Splash_Screen_Form : Form
    {
        public Splash_Screen_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Splash_Screen_Form_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(30); // adjust radius here

            pictureBox2.Size = pictureBox3.Size = pictureBox4.Size = pictureBox5.Size = new Size(0, 0);
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
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void timer1_Tick(object sender, EventArgs e)
        { 
            pictureBox2.Size = new Size(pictureBox2.Width + 2, pictureBox2.Height + 2);
            pictureBox2.Location = new Point(pictureBox2.Location.X - 1, pictureBox2.Location.Y - 1);
            if (pictureBox2.Width == 24)
            {
                timer3.Start();
            }
            else if (pictureBox2.Width == 50)
            {
                timer1.Stop(); timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(pictureBox2.Width - 2, pictureBox2.Height - 2);
            pictureBox2.Location = new Point(pictureBox2.Location.X + 1, pictureBox2.Location.Y + 1);
            if (pictureBox2.Width == 0)
            {
                timer2.Stop();
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(pictureBox3.Width + 2, pictureBox3.Height + 2);
            pictureBox3.Location = new Point(pictureBox3.Location.X - 1, pictureBox3.Location.Y - 1);
            if (pictureBox3.Width == 24)
            {
                timer5.Start();
            }
            else if (pictureBox3.Width == 50)
            {
                timer3.Stop(); timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(pictureBox3.Width - 2, pictureBox3.Height - 2);
            pictureBox3.Location = new Point(pictureBox3.Location.X + 1, pictureBox3.Location.Y + 1);
            if (pictureBox3.Width == 0)
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(pictureBox4 .Width + 2, pictureBox4.Height + 2);
            pictureBox4.Location = new Point(pictureBox4.Location.X - 1, pictureBox4.Location.Y - 1);
            if (pictureBox4.Width == 24)
            {
                timer7.Start();
            }
            else if (pictureBox4.Width == 50)
            {
                timer5.Stop(); timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(pictureBox4.Width - 2, pictureBox4.Height - 2);
            pictureBox4.Location = new Point(pictureBox4.Location.X + 1, pictureBox4.Location.Y + 1);
            if (pictureBox4.Width == 0)
            {
                timer6.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(pictureBox5.Width + 2, pictureBox5.Height + 2);
            pictureBox5.Location = new Point(pictureBox5.Location.X - 1, pictureBox5.Location.Y - 1);
            
            if (pictureBox5.Width == 50)
            {
                timer7.Stop(); timer8.Start(); timer1.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(pictureBox5.Width - 2, pictureBox5.Height - 2);
            pictureBox5.Location = new Point(pictureBox5.Location.X + 1, pictureBox5.Location.Y + 1);
            if (pictureBox5.Width == 0)
            {
                timer8.Stop();
                // sequence finished — close the splash so Program.Main can open the main form
                this.Close();       
            }
        }
    }
}
