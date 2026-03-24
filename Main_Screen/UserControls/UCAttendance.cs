using Brevi.Domain.Models;
using Brevi.Domain.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCAttendance : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int CurrentSectionId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public UserControl CallerControl { get; set; }

        private DateTime _selectedDate = DateTime.Today;
        private enum SortMethod { Surname, FirstName }
        private SortMethod _currentSort = SortMethod.Surname;

        private readonly ISectionService _sectionService;

        public UCAttendance()
        {
            InitializeComponent();
            UpdateDateDisplay();
            SetSection(CurrentSectionId);
        }

        public void SetSection(int sectionId)
        {
            CurrentSectionId = sectionId;
            LoadSectionInfo();
            LoadStudentsForDate();
            SetSummaryCards();
        }

        private void RoundPanel(object sender, EventArgs e)
        {
            if (sender is Control panel)
            {
                UIHelper.RoundControl(panel, 20);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (FormAddStudent popup = new FormAddStudent())
            {
                MainScreenForm mainForm = (MainScreenForm)this.FindForm();
                mainForm.ShowOverlay();
                popup.CurrentSectionId = CurrentSectionId;
                var result = popup.ShowDialog();
                mainForm.HideOverlay();
                LoadStudentsForDate();
                SetSummaryCards();
            }
        }

        private void SetSummaryCards()
        {
            try
            {
                if (CurrentSectionId == 0)
                {
                    pnlTotalStudents.Title = "Total Students";
                    pnlTotalStudents.TitleColor = "77, 180, 170";
                    pnlTotalStudents.Integer = 0;
                    pnlTotalStudents.IntegerColor = "39, 165, 173";
                    pnlTotalStudents.Percentage = string.Empty;
                    pnlTotalStudents.PercentageColor = "77, 180, 170";

                    pnlPresent.Title = "Present";
                    pnlPresent.TitleColor = "72, 205, 121";
                    pnlPresent.Integer = 0;
                    pnlPresent.IntegerColor = "34, 195, 93";
                    pnlPresent.Percentage = "0.0%";
                    pnlPresent.PercentageColor = "72, 205, 121";

                    pnlLate.Title = "Late";
                    pnlLate.TitleColor = "246, 175, 53";
                    pnlLate.Integer = 0;
                    pnlLate.IntegerColor = "245, 159, 10";
                    pnlLate.Percentage = "0.0%";
                    pnlLate.PercentageColor = "246, 175, 53";

                    pnlAbsent.Title = "Absent";
                    pnlAbsent.TitleColor = "230, 110, 110";
                    pnlAbsent.Integer = 0;
                    pnlAbsent.IntegerColor = "223, 58, 58";
                    pnlAbsent.Percentage = "0.0%";
                    pnlAbsent.PercentageColor = "230, 110, 110";

                    pnlExcused.Title = "Excused";
                    pnlExcused.TitleColor = "55, 178, 235";
                    pnlExcused.Integer = 0;
                    pnlExcused.IntegerColor = "13, 162, 231";
                    pnlExcused.Percentage = "0.0%";
                    pnlExcused.PercentageColor = "55, 178, 235";
                    return;
                }

                using var _context = new AppDbContext();

                int total = _context.Students.Count(s => s.SectionId == CurrentSectionId);

                DateTime dateStart = _selectedDate.Date;
                DateTime dateEnd = dateStart.AddDays(1);

                var attendance = _context.AttendanceRecords
                    .Where(a => a.SectionId == CurrentSectionId && a.Date >= dateStart && a.Date < dateEnd)
                    .AsNoTracking()
                    .ToList();

                int present = attendance.Count(a => a.Status == AttendanceStatus.Present);
                int late = attendance.Count(a => a.Status == AttendanceStatus.Late);
                int absent = attendance.Count(a => a.Status == AttendanceStatus.Absent);
                int excused = attendance.Count(a => a.Status == AttendanceStatus.Excused);

                double pctPresent = total > 0 ? (present * 100.0) / total : 0.0;
                double pctLate = total > 0 ? (late * 100.0) / total : 0.0;
                double pctAbsent = total > 0 ? (absent * 100.0) / total : 0.0;
                double pctExcused = total > 0 ? (excused * 100.0) / total : 0.0;

                pnlTotalStudents.Title = "Total Students";
                pnlTotalStudents.Integer = total;
                pnlTotalStudents.Percentage = string.Empty;

                pnlPresent.Title = "Present";
                pnlPresent.Integer = present;
                pnlPresent.Percentage = $"{pctPresent:0.0}%";

                pnlLate.Title = "Late";
                pnlLate.Integer = late;
                pnlLate.Percentage = $"{pctLate:0.0}%";

                pnlAbsent.Title = "Absent";
                pnlAbsent.Integer = absent;
                pnlAbsent.Percentage = $"{pctAbsent:0.0}%";

                pnlExcused.Title = "Excused";
                pnlExcused.Integer = excused;
                pnlExcused.Percentage = $"{pctExcused:0.0}%";
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] SetSummaryCards error: " + ex);
            }
        }

        private void LoadSectionInfo()
        {
            lblSectionName.Text = "Loading...";
            lblSubjectName.Text = string.Empty;

            if (CurrentSectionId == 0)
            {
                lblSectionName.Text = "No section selected";
                lblSubjectName.Text = string.Empty;
                return;
            }

            try
            {
                using var _context = new AppDbContext();

                var section = _context.Sections
                    .AsNoTracking()
                    .Where(s => s.Id == CurrentSectionId)
                    .Select(s => new { s.SectionName, s.Subject })
                    .SingleOrDefault();

                if (section != null)
                {
                    lblSectionName.Text = section.SectionName;
                    lblSubjectName.Text = section.Subject.ToString();
                }
                else
                {
                    lblSectionName.Text = "Section not found";
                    lblSubjectName.Text = string.Empty;
                    Debug.WriteLine($"[UC_Attendance] Section with ID {CurrentSectionId} was not found.");
                }
            }
            catch (Exception ex)
            {
                lblSectionName.Text = "Error loading section";
                lblSubjectName.Text = string.Empty;
                Debug.WriteLine($"[UC_Attendance] LoadSectionInfo error: {ex}");
            }
        }

        public void LoadStudentsForDate()
        {
            if (CurrentSectionId == 0)
            {
                lblNumberofStudents.Text = "0 Students";
                return;
            }

            Point scrollPos = layoutStudents.AutoScrollPosition;

            layoutStudents.SuspendLayout();
            layoutStudents.Controls.Clear();

            layoutStudents.AutoScrollPosition = new Point(0, 0);
            using (var _context = new AppDbContext())
            {
                var studentsQuery = _context.Students.Where(s => s.SectionId == this.CurrentSectionId);

                if (_currentSort == SortMethod.Surname)
                {
                    studentsQuery = studentsQuery.OrderBy(s => s.LastName).ThenBy(s => s.FirstName);
                }
                else
                {
                    studentsQuery = studentsQuery.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
                }

                var students = studentsQuery.ToList();

                DateTime dateStart = _selectedDate.Date;
                DateTime dateEnd = dateStart.AddDays(1);

                var attendanceForDay = _context.AttendanceRecords
                    .Where(a => a.SectionId == this.CurrentSectionId
                                && a.Date >= dateStart && a.Date < dateEnd)
                    .AsNoTracking()
                    .ToList()
                    .ToDictionary(a => a.StudentId, a => a.Status);

                int count = 1;
                foreach (var student in students)
                {
                    UCStudentRow studentRow = new UCStudentRow();

                    studentRow.StudentId = student.Id;
                    studentRow.SectionId = this.CurrentSectionId;
                    studentRow.AttendanceDate = _selectedDate;

                    if (_currentSort == SortMethod.Surname)
                    {
                        studentRow.StudentName = $"{student.LastName}, {student.FirstName}";
                    }
                    else
                    {
                        studentRow.StudentName = $"{student.FirstName} {student.LastName}";
                    }

                    studentRow.StudentNumber = count.ToString();

                    if (attendanceForDay.TryGetValue(student.Id, out var status))
                    {
                        studentRow.SetSelectedStatus(status);
                    }
                    else
                    {
                        studentRow.SetSelectedStatus(null);
                    }
                    studentRow.Width = layoutStudents.ClientSize.Width - studentRow.Margin.Left - studentRow.Margin.Right - 5;
                    studentRow.AttendanceStatusChanged += StudentRow_AttendanceStatusChanged;
                    layoutStudents.Controls.Add(studentRow);
                    count++;
                }

                lblNumberofStudents.Text = $"{students.Count} Students";
            }

            layoutStudents.ResumeLayout();

            layoutStudents.AutoScrollPosition = new Point(Math.Abs(scrollPos.X), Math.Abs(scrollPos.Y));

            SetSummaryCards();
        }
        private void StudentRow_AttendanceStatusChanged(object sender, int studentId)
        {
            RecalculateSingleStudentGrade(studentId, CurrentSectionId);
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {
            UpdateDateDisplay();

            if (CurrentSectionId != 0)
            {
                LoadSectionInfo();
                LoadStudentsForDate();
            }

            RoundPanel(pnlTotalStudents, EventArgs.Empty);
            RoundPanel(panelTotalBorder, EventArgs.Empty);
            RoundPanel(pnlPresent, EventArgs.Empty);
            RoundPanel(panelPresentBorder, EventArgs.Empty);
            RoundPanel(pnlLate, EventArgs.Empty);
            RoundPanel(panelLateBorder, EventArgs.Empty);
            RoundPanel(pnlAbsent, EventArgs.Empty);
            RoundPanel(panelAbsentBorder, EventArgs.Empty);
            RoundPanel(pnlExcused, EventArgs.Empty);
            RoundPanel(panelExcusedBorder, EventArgs.Empty);
            RoundPanel(panelCalendar, EventArgs.Empty);
            RoundPanel(panelCalendarBorder, EventArgs.Empty);
        }

        private void lblBackToClass_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as MainScreenForm;
            if (mainForm == null)
                return;

            if (CallerControl != null)
            {
                mainForm.LoadForm(CallerControl);
            }
            else
            {
                mainForm.LoadForm(new UCClasses(_sectionService));
            }
        }

        private void UpdateDateDisplay()
        {
            lblDateNow.Values.ExtraText = _selectedDate.ToString("D");
        }

        private void lblDateNow_Click(object? sender, EventArgs e)
        {
            ShowCalendarPicker();
        }

        private void btnNextDate_Click(object? sender, EventArgs e)
        {
            _selectedDate = _selectedDate.AddDays(1);
            UpdateDateDisplay();
            LoadStudentsForDate();
        }

        private void btnPreviousDate_Click(object? sender, EventArgs e)
        {
            _selectedDate = _selectedDate.AddDays(-1);
            UpdateDateDisplay();
            LoadStudentsForDate();
        }

        private void ShowCalendarPicker()
        {
            var container = new Panel { BackColor = Color.White, Size = new Size(245, 250) };

            var cbMonth = new Krypton.Toolkit.KryptonComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 110,
                Location = new Point(10, 5)
            };
            cbMonth.Items.AddRange(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cbMonth.SelectedIndex = _selectedDate.Month - 1;

            var numYear = new Krypton.Toolkit.KryptonNumericUpDown
            {
                Width = 80,
                Location = new Point(130, 5),
                Minimum = 2000,
                Maximum = 2100,
                Value = _selectedDate.Year
            };

            var cal = new Krypton.Toolkit.KryptonMonthCalendar
            {
                MaxSelectionCount = 1,
                SelectionStart = _selectedDate,
                SelectionEnd = _selectedDate,
                ShowTodayCircle = false,
                ShowWeekNumbers = false,
                Location = new Point(5, 35)
            };

            cal.StateCommon.Back.Color1 = Color.White;
            cal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;

            cal.StateTracking.Day.Back.Color1 = Color.FromArgb(228, 242, 240);
            cal.StateTracking.Day.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            cal.StateTracking.Day.Border.Rounding = 6F;
            cal.StateTracking.Day.Border.Width = 0;

            cal.StateCheckedNormal.Day.Back.Color1 = Color.FromArgb(39, 165, 173);
            cal.StateCheckedNormal.Day.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            cal.StateCheckedNormal.Day.Border.Rounding = 6F;
            cal.StateCheckedNormal.Day.Border.Width = 0;
            cal.StateCheckedNormal.Day.Content.ShortText.Color1 = Color.White;

            container.Controls.Add(cbMonth);
            container.Controls.Add(numYear);
            container.Controls.Add(cal);

            var host = new ToolStripControlHost(container) { Padding = Padding.Empty, Margin = Padding.Empty };
            var dropDown = new ToolStripDropDown { Padding = new Padding(1), BackColor = Color.FromArgb(224, 230, 235) };
            dropDown.Items.Add(host);

            bool isNavigating = false;

            cbMonth.SelectedIndexChanged += (s, e) =>
            {
                isNavigating = true;
                cal.SetDate(new DateTime((int)numYear.Value, cbMonth.SelectedIndex + 1, 1));
                isNavigating = false;
            };

            numYear.ValueChanged += (s, e) =>
            {
                isNavigating = true;
                cal.SetDate(new DateTime((int)numYear.Value, cbMonth.SelectedIndex + 1, 1));
                isNavigating = false;
            };

            cal.DateChanged += (s, e) =>
            {
                if (isNavigating) return;

                _selectedDate = cal.SelectionStart.Date;
                UpdateDateDisplay();
                LoadStudentsForDate();
                dropDown.Close();
            };

            int offsetX = (lblDateNow.Width - container.Width) / 2;
            int offsetY = lblDateNow.Height + 4;

            dropDown.Show(lblDateNow, new Point(offsetX, offsetY));
        }

        private void btnMarkAllPresent_Click(object? sender, EventArgs e)
        {
            if (CurrentSectionId == 0) return;

            try
            {
                DateTime dateStart = _selectedDate.Date;
                DateTime dateEnd = dateStart.AddDays(1);

                using var _context = new AppDbContext();

                var students = _context.Students.Where(s => s.SectionId == CurrentSectionId).ToList();

                foreach (var student in students)
                {
                    var existing = _context.AttendanceRecords
                        .FirstOrDefault(a => a.StudentId == student.Id
                                             && a.SectionId == CurrentSectionId
                                             && a.Date >= dateStart && a.Date < dateEnd);

                    if (existing == null)
                    {
                        _context.AttendanceRecords.Add(new Attendance
                        {
                            StudentId = student.Id,
                            SectionId = CurrentSectionId,
                            Date = dateStart,
                            Status = AttendanceStatus.Present,
                            Remarks = string.Empty
                        });
                    }
                    else
                    {
                        existing.Status = AttendanceStatus.Present;
                    }
                }

                _context.SaveChanges();

                RecalculateClassGrades(_context, CurrentSectionId);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnMarkAllPresent error: " + ex);
            }

            foreach (Control control in layoutStudents.Controls)
            {
                if (control is UCStudentRow studentRow)
                {
                    studentRow.SetSelectedStatus(AttendanceStatus.Present);
                }
            }
            SetSummaryCards();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            if (CurrentSectionId == 0) return;

            try
            {
                DateTime dateStart = _selectedDate.Date;
                DateTime dateEnd = dateStart.AddDays(1);

                using var _context = new AppDbContext();

                var toRemove = _context.AttendanceRecords
                    .Where(a => a.SectionId == CurrentSectionId && a.Date >= dateStart && a.Date < dateEnd)
                    .ToList();

                if (toRemove.Any())
                {
                    _context.AttendanceRecords.RemoveRange(toRemove);
                    _context.SaveChanges();

                    RecalculateClassGrades(_context, CurrentSectionId);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnReset error: " + ex);
            }

            foreach (Control control in layoutStudents.Controls)
            {
                if (control is UCStudentRow studentRow)
                {
                    studentRow.SetSelectedStatus(null);
                }
            }
            SetSummaryCards();
        }

        public void RefreshSummaryAndRoster()
        {
            SetSummaryCards();
        }

        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            if (CurrentSectionId == 0)
            {
                MessageBox.Show("No section selected to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormAttendanceSummary summaryForm = new FormAttendanceSummary(CurrentSectionId))
            {
                MainScreenForm mainForm = (MainScreenForm)this.FindForm();
                if (mainForm != null) mainForm.ShowOverlay();
                summaryForm.ShowDialog();
                if (mainForm != null) mainForm.HideOverlay();
            }
        }

        private void btnSortSurname_Click(object sender, EventArgs e)
        {
            _currentSort = SortMethod.Surname;
            LoadStudentsForDate();
        }

        private void btnSortFirstname_Click(object sender, EventArgs e)
        {
            _currentSort = SortMethod.FirstName;
            LoadStudentsForDate();
        }
        public void RecalculateSingleStudentGrade(int studentId, int sectionId)
        {
            using (var db = new AppDbContext())
            {
                var section = db.Sections.FirstOrDefault(s => s.Id == sectionId);
                if (section == null) return;

                var records = db.AttendanceRecords
                                .Where(a => a.StudentId == studentId && a.SectionId == sectionId)
                                .ToList();

                int total = records.Count;
                int p = records.Count(r => r.Status == AttendanceStatus.Present);
                int e = records.Count(r => r.Status == AttendanceStatus.Excused);
                int l = records.Count(r => r.Status == AttendanceStatus.Late);
                int a = records.Count(r => r.Status == AttendanceStatus.Absent);

                double points = (p * 1.0) + (e * 1.0) + (l * 0.5) + (a * 0.0);
                double percentage = total > 0 ? (points / total) * 100.0 : 0;

                var grade = db.Grades.FirstOrDefault(g => g.StudentId == studentId && g.SectionId == sectionId);

                if (grade == null)
                {
                    db.Grades.Add(new Grade
                    {
                        StudentId = studentId,
                        SectionId = sectionId,
                        Subject = section.Subject,
                        Percentage = percentage
                    });
                }
                else
                {
                    grade.Percentage = percentage;
                }

                db.SaveChanges();
            }
        }
        public void RecalculateClassGrades(AppDbContext db, int sectionId)
        {
            var section = db.Sections.FirstOrDefault(s => s.Id == sectionId);
            if (section == null) return;

            var studentIds = db.Students.Where(s => s.SectionId == sectionId).Select(s => s.Id).ToList();
            var allAttendance = db.AttendanceRecords.Where(a => a.SectionId == sectionId).ToList();
            var allGrades = db.Grades.Where(g => g.SectionId == sectionId).ToList();

            foreach (var sId in studentIds)
            {
                var records = allAttendance.Where(a => a.StudentId == sId).ToList();

                int total = records.Count;
                int p = records.Count(r => r.Status == AttendanceStatus.Present);
                int e = records.Count(r => r.Status == AttendanceStatus.Excused);
                int l = records.Count(r => r.Status == AttendanceStatus.Late);

                double points = p + e + (l * 0.5);
                double percentage = total > 0 ? (points / total) * 100.0 : 0;

                var grade = allGrades.FirstOrDefault(g => g.StudentId == sId);
                if (grade == null)
                {
                    db.Grades.Add(new Grade
                    {
                        StudentId = sId,
                        SectionId = sectionId,
                        Subject = section.Subject,
                        Percentage = percentage
                    });
                }
                else
                {
                    grade.Percentage = percentage;
                }
            }
        }
        private void layoutStudents_SizeChanged(object sender, EventArgs e)
        {
            layoutStudents.SuspendLayout();

            int targetWidth = layoutStudents.ClientSize.Width - 3 - 3 - 5;

            foreach (Control ctrl in layoutStudents.Controls)
            {
                if (ctrl is UCStudentRow)
                {
                    ctrl.Width = targetWidth;
                }
            }

            layoutStudents.ResumeLayout();
        }
    }
}
