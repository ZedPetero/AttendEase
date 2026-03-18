using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AE.Application;
using ComponentFactory.Krypton.Toolkit;
namespace AE.Application
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            UIHelper.RoundControl(this.kryptonPanel1, 20);
            UIHelper.RoundControl(this.kryptonPanel2, 20);
            UIHelper.RoundControl(this.kryptonPanel3, 20);
            UIHelper.RoundControl(this.kryptonPanel4, 20);
            UIHelper.RoundControl(this.kryptonPanel5, 20);
            UIHelper.RoundControl(this.kryptonPanel6, 20);
            UIHelper.RoundControl(this.kryptonPanel7, 20);
            UIHelper.RoundControl(this.kryptonPanel8, 20);
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            MainScreenForm mainForm = (MainScreenForm)this.FindForm();
            if (mainForm != null)
            {
                mainForm.NavigateToClasses();
            }
        }

        private bool isCard1Raised = false;
        private bool isCard2Raised = false;
        private bool isCard3Raised = false;
        private bool isCard4Raised = false;

        private void Card1_MouseEnter(object sender, EventArgs e)
        {
            if (!isCard1Raised)
            {
                isCard1Raised = true;
                int x = kryptonPanel1.Location.X;
                int y = kryptonPanel1.Location.Y;
                kryptonPanel1.Location = new Point(x, y - 5);
            }
        }

        private void Card1_MouseLeave(object sender, EventArgs e)
        {
            if (isCard1Raised)
            {
                isCard1Raised = false;
                int x = kryptonPanel1.Location.X;
                int y = kryptonPanel1.Location.Y;
                kryptonPanel1.Location = new Point(x, y + 5);
            }
        }

        private void Card2_MouseEnter(object sender, EventArgs e)
        {
            if (!isCard2Raised)
            {
                isCard2Raised = true;
                int x = kryptonPanel2.Location.X;
                int y = kryptonPanel2.Location.Y;
                kryptonPanel2.Location = new Point(x, y - 5);
            }
        }

        private void Card2_MouseLeave(object sender, EventArgs e)
        {
            if (isCard2Raised)
            {
                isCard2Raised = false;
                int x = kryptonPanel2.Location.X;
                int y = kryptonPanel2.Location.Y;
                kryptonPanel2.Location = new Point(x, y + 5);
            }
        }

        private void Card3_MouseEnter(object sender, EventArgs e)
        {
            if (!isCard3Raised)
            {
                isCard3Raised = true;
                int x = kryptonPanel3.Location.X;
                int y = kryptonPanel3.Location.Y;
                kryptonPanel3.Location = new Point(x, y - 5);
            }
        }

        private void Card3_MouseLeave(object sender, EventArgs e)
        {
            if (isCard3Raised)
            {
                isCard3Raised = false;
                int x = kryptonPanel3.Location.X;
                int y = kryptonPanel3.Location.Y;
                kryptonPanel3.Location = new Point(x, y + 5);
            }
        }
        private void Card4_MouseEnter(object sender, EventArgs e)
        {
            if (!isCard4Raised)
            {
                isCard4Raised = true;
                int x = kryptonPanel4.Location.X;
                int y = kryptonPanel4.Location.Y;
                kryptonPanel4.Location = new Point(x, y - 5);
            }
        }

        private void Card4_MouseLeave(object sender, EventArgs e)
        {
            if (isCard4Raised)
            {
                isCard4Raised = false;
                int x = kryptonPanel4.Location.X;
                int y = kryptonPanel4.Location.Y;
                kryptonPanel4.Location = new Point(x, y + 5);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
