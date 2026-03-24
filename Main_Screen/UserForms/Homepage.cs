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

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {
            UIHelper.RoundControl(kryptonLabel2, 20);
        }
    }
}
