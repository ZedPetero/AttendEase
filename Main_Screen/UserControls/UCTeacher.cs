using AE.Application.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UCTeacher : UserControl
    {
        private UCEditTeacher _activeEditTeacher;
        public UCTeacher()
        {
            InitializeComponent();
            ShowProfileMode();
            UIHelper.RoundControl(panelTeacherProfile, 20);
        }

        public void LoadForm(UserControl customizedControl)
        {
            panelTeacherProfile.Controls.Clear();
            customizedControl.Dock = DockStyle.Fill;
            panelTeacherProfile.Controls.Add(customizedControl);
            panelTeacherProfile.SendToBack();
        }
        public void LoadButtonForm(UserControl customizedButton)
        {
            panel1.Controls.Clear();
            customizedButton.Dock = DockStyle.Fill;
            panel1.Controls.Add(customizedButton);
            customizedButton.BringToFront();
        }
        public void ShowProfileMode()
        {
            UCTeacherProfile teacherProfile = new UCTeacherProfile();
            LoadForm(teacherProfile);

            EditBtnTeacher editBtnControl = new EditBtnTeacher();

            editBtnControl.Click += EditBtnControl_Click;

            LoadButtonForm(editBtnControl);
        }

        public void ShowEditMode()
        {
            _activeEditTeacher = new UCEditTeacher();
            LoadForm(_activeEditTeacher);

            SaveBtnTeacher saveBtnControl = new SaveBtnTeacher();

            saveBtnControl.SaveChangesClicked += SaveBtnControl_SaveChangesClicked;
            saveBtnControl.CancelEditClicked += SaveBtnControl_CancelEditClicked;

            LoadButtonForm(saveBtnControl);
        }
        private void EditBtnControl_Click(object sender, EventArgs e)
        {
            ShowEditMode();
        }
        private void SaveBtnControl_SaveChangesClicked(object sender, EventArgs e)
        {
            if (_activeEditTeacher != null)
            {
                bool saveWasSuccessful = _activeEditTeacher.SaveTeacherData();
                if (saveWasSuccessful)
                {
                    ShowProfileMode();
                }
            }
        }

        private void SaveBtnControl_CancelEditClicked(object sender, EventArgs e)
        {
            ShowProfileMode();
        }
    }
}
