using AE.Application.UserControls;
using AE.Domain.Models;
using AE.Infrastructure.Data;
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

namespace AE.Application
{
    public partial class UC_Classes : UserControl
    {
        public UC_Classes()
        {
            InitializeComponent();
            lblTeacher.Text = $"Welcome, {UserSession.CurrentTeacherName}!";
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadSections();
        }
        public void LoadSections()
        {
            try
            {
                flowLayoutPanelCards.Controls.Clear();

                using (var db = new AppDbContext())
                {
                    var mySections = db.Sections
                        .Where(s => s.TeacherId == UserSession.CurrentTeacherId 
                                && s.IsArchived == false)
                        .Select(s => new
                        {
                            s.Id,
                            s.SectionName,
                            SubjectName = s.Subject.ToString(),
                            StudentCount = s.Students.Count,
                            s.StartTimeSchedule,
                            s.EndTimeSchedule,
                            s.IsArchived
                        })
                        .ToList()
                        .OrderBy(s => s.StartTimeSchedule)
                        .ToList();
                    foreach (var section in mySections)
                    {
                        string timeString = DateTime.Today.Add(section.StartTimeSchedule).ToString("hh:mm tt") +
                                    " - " +
                                    DateTime.Today.Add(section.EndTimeSchedule).ToString("hh:mm tt");
                        UC_SectionCard card = new UC_SectionCard();
                        card.SetData(section.Id, section.SectionName, section.SubjectName, section.StudentCount, timeString);
                        card.TakeAttendanceClicked += Card_TakeAttendanceClicked;
                        card.SectionDeleted += (s, sectionId) =>
                        {
                            LoadSections();
                        };
                        flowLayoutPanelCards.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading sections. Please try again later.\n\n" + ex.Message);
            }
        }
        private void Card_TakeAttendanceClicked(object sender, int sectionId)
        {
            Main_Screen_Form mainForm = (Main_Screen_Form)this.FindForm();
            UC_Attendance attendanceScreen = new UC_Attendance();

            attendanceScreen.CallerControl = this;
            attendanceScreen.SetSection(sectionId);

            mainForm.loadForm(attendanceScreen);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                //ShowFloatingPanel cover = new ShowFloatingPanel();
                //cover.BackColor = Color.FromArgb(128, Color.Gray);
                //cover.Show();
                AddSectionForm form = new AddSectionForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadSections();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
