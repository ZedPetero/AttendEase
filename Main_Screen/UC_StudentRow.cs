using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UC_StudentRow : UserControl
    {
        public UC_StudentRow()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentName
        {
            get { return lblStudentName.Text; }
            set { lblStudentName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentNumber
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentStatus
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        private void UC_StudentRow_Load(object sender, EventArgs e)
        {
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(lblNumber, 18);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    UIHelper.RoundControl(c, 5);
                }
            }
        }
    }
}
