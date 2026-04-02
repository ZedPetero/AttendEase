using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCInteractionPage : UserControl
    {
        public event EventHandler? StartNowClicked;

        public UCInteractionPage()
        {
            InitializeComponent();
        }

        private void btnStartNow_Click(object sender, EventArgs e)
        {
            StartNowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
