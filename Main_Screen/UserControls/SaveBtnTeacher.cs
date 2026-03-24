using Brevi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application.UserControls
{
    public partial class SaveBtnTeacher : UserControl
    {
        public SaveBtnTeacher()
        {
            InitializeComponent();
        }
        public event EventHandler SaveChangesClicked;
        public event EventHandler CancelEditClicked;
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            CancelEditClicked?.Invoke(this, e);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChangesClicked?.Invoke(this, e);
        }
    }
}
