using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application.UserControls
{
    public partial class EditBtnTeacher : UserControl
    {
        public EditBtnTeacher()
        {
            InitializeComponent();
        }
        public event EventHandler EditClicked;
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void EditBtnTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
