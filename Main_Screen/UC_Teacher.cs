using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UC_Teacher : UserControl
    {
        bool isEditing;

        public UC_Teacher()
        {
            InitializeComponent();
            UCTeacherProfile teacherProfile = new UCTeacherProfile();
            LoadForm(teacherProfile);
            isEditing = false;
        }

        public void LoadForm(UserControl customizedControl)
        {
            panelTeacherProfile.Controls.Clear();
            customizedControl.Dock = DockStyle.Fill;
            panelTeacherProfile.Controls.Add(customizedControl);
            panelTeacherProfile.SendToBack();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                UCEditTeacher editTeacher = new UCEditTeacher();
                btnEditProfile.Text = "\e161";
                btnEditProfile.Values.ExtraText = "Save";
                LoadForm(editTeacher);
            } else
            {
                UCTeacherProfile teacherProfile = new UCTeacherProfile();
                btnEditProfile.Text = "\e3c9";
                btnEditProfile.Values.ExtraText = "Edit";
                LoadForm(teacherProfile);
            }
        }
    }
}
