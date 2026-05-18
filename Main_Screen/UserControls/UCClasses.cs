using Brevi.Application.UserControls;
using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;
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
        private readonly IAttendanceService _attendanceService;
        private readonly IAttendanceWeightsService _attendanceWeightsService;
        private readonly IGradeService _gradeService;
        private readonly IStudentService _studentService;
        private readonly IRepository<Subject> _subjectRepository;
        public UCClasses(ISectionService sectionService, IAttendanceService attendanceService, IGradeService gradeService, IStudentService studentService, IAttendanceWeightsService attendanceWeightsService, IRepository<Subject> subjectRepository)
        {
            InitializeComponent();
            _sectionService = sectionService;
            _attendanceService = attendanceService;
            _gradeService = gradeService;
            _studentService = studentService;
            _subjectRepository = subjectRepository;
            _attendanceWeightsService = attendanceWeightsService;
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
                var sortedSections = sections.OrderBy(s => s.StartTime).ToList();
                foreach (var section in sortedSections)
                {
                    string timeString =
                        DateTime.Today.Add(section.StartTime).ToString("hh:mm tt")
                        + " - " +
                        DateTime.Today.Add(section.EndTime).ToString("hh:mm tt");

                    UCSectionCard card = new UCSectionCard(_sectionService);

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
            UCAttendance attendanceScreen = new UCAttendance(_sectionService, _attendanceService, _gradeService, _studentService, _attendanceWeightsService, _subjectRepository);

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

                AddSectionForm form = new AddSectionForm(_sectionService, _subjectRepository);

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
