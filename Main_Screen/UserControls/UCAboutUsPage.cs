using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCAboutUsPage : UserControl
    {
        public UCAboutUsPage()
        {
            InitializeComponent();
            UIHelper.RoundControl(panel2, 10);
            UIHelper.RoundControl(panel4, 10);
            UIHelper.RoundControl(panel6, 10);
        }
    }
}
