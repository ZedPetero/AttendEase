using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UC_Records_New : UserControl
    {
        public UC_Records_New()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            UIHelper.RoundControl(CurrentClassespanel, 20);
        }

        private void kryptonPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            UIHelper.RoundControl(ArchivedClassespanel, 20);
        }
    }
}
