using Brevi.Application.UserControls;
using Brevi.Services.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCTeacher : UserControl
    {
        private readonly ITeacherService _teacherService;
        private UCEditTeacher _activeEditTeacher;
        public UCTeacher(ITeacherService teacherService)
        {
            InitializeComponent();
            _teacherService = teacherService;
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
        public async void ShowProfileMode()
        {
            UCTeacherProfile teacherProfile = new UCTeacherProfile(_teacherService);
            LoadForm(teacherProfile);
            _= teacherProfile.LoadTeacherProfileAsync(); 
            EditBtnTeacher editBtnControl = new EditBtnTeacher();

            editBtnControl.Click += EditBtnControl_Click;

            LoadButtonForm(editBtnControl);
        }

        public void ShowEditMode()
        {
            _activeEditTeacher = new UCEditTeacher(_teacherService);
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
        private async void SaveBtnControl_SaveChangesClicked(object sender, EventArgs e)
        {
            if (_activeEditTeacher == null) return;

            try
            {
                if (sender is Control btn) btn.Enabled = false;

                bool saveWasSuccessful = await _activeEditTeacher.SaveTeacherDataAsync();

                if (saveWasSuccessful)
                {
                    ShowProfileMode();
                }
                else
                {
                    MessageBox.Show("The save operation was rejected by the service. Check your data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Critical error during save: {ex.Message}");
            }
            finally
            {
                if (sender is Control btn) btn.Enabled = true;
            }
        }

        private void SaveBtnControl_CancelEditClicked(object sender, EventArgs e)
        {
            ShowProfileMode();
        }
    }
}
