using Brevi.Application.UserControls;
using Brevi.Domain.Models;
using Brevi.Domain.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Syncfusion.Grouping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCClasses : UserControl
    {
        private readonly ISectionService _sectionService;
        public UCClasses(ISectionService sectionService)
        {
            InitializeComponent();
            _sectionService = sectionService;
            lblTeacher.Text = $"Welcome, {UserSession.CurrentTeacherName}!";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadSections();
        }
        public async void LoadSections()
        {
            try
            {
                flowLayoutPanelCards.Controls.Clear();

                var sections = await _sectionService
                    .GetTeacherSectionsAsync(UserSession.CurrentTeacherId);

                foreach (var section in sections)
                {
                    string timeString =
                        DateTime.Today.Add(section.StartTime).ToString("hh:mm tt")
                        + " - " +
                        DateTime.Today.Add(section.EndTime).ToString("hh:mm tt");

                    UCSectionCard card = new UCSectionCard();

                    card.SetData(
                        section.Id,
                        section.SectionName,
                        section.SubjectName,
                        section.StudentCount,
                        timeString);

                    card.TakeAttendanceClicked += Card_TakeAttendanceClicked;

                    card.SectionDeleted += (s, sectionId) =>
                    {
                        LoadSections();
                    };

                    flowLayoutPanelCards.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading sections. Please try again later.\n\n" + ex.Message);
            }
        }
        private void Card_TakeAttendanceClicked(object sender, int sectionId)
        {
            MainScreenForm mainForm = (MainScreenForm)this.FindForm();
            UCAttendance attendanceScreen = new UCAttendance();

            attendanceScreen.CallerControl = this;
            attendanceScreen.SetSection(sectionId);

            mainForm.LoadForm(attendanceScreen);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                MainScreenForm mainForm = (MainScreenForm)this.FindForm();

                mainForm.ShowOverlay();

                AddSectionForm form = new AddSectionForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSections();
                }

                mainForm.HideOverlay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
