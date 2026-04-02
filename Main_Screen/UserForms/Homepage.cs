using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            UIHelper.RoundControl(this, 20);
        }

        // Removed unused handler for missing kryptonLabel2 control

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
