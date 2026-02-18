using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class Register_Screen_Form : Form
    {
        public Register_Screen_Form()
        {
            InitializeComponent();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {

        }
    }
}
