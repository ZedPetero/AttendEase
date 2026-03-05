using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AE.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Diagnostics;
using AE.Domain.Models;

namespace AE.Application
{
    public partial class UC_Attendance : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int CurrentSectionId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public UserControl CallerControl { get; set; }

        private DateTime _selectedDate = DateTime.Today;

        public UC_Attendance()
        {
            InitializeComponent();
            UpdateDateDisplay();
        }

        public void SetSection(int sectionId)
        {
            CurrentSectionId = sectionId;
            LoadSectionInfo();
            LoadStudentsForDate();
            SetSummaryCards(); 
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (Form_AddStudent popup = new Form_AddStudent())
            {
                popup.CurrentSectionId = CurrentSectionId;
                var result = popup.ShowDialog();
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
                    pnlTotalStudents.Integer = 0;
                    pnlTotalStudents.Percentage = string.Empty;

                    pnlPresent.Title = "Present";
                    pnlPresent.Integer = 0;
                    pnlPresent.Percentage = "0.0%";

                    pnlLate.Title = "Late";
                    pnlLate.Integer = 0;
                    pnlLate.Percentage = "0.0%";

                    pnlAbsent.Title = "Absent";
                    pnlAbsent.Integer = 0;
                    pnlAbsent.Percentage = "0.0%";

                    pnlExcused.Title = "Excused";
                    pnlExcused.Integer = 0;
                    pnlExcused.Percentage = "0.0%";
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

        private void LoadStudentsForDate()
        {
            layoutStudents.Controls.Clear();

            if (CurrentSectionId == 0)
            {
                lblNumberofStudents.Text = "0 Students";
                return;
            }

            using (var _context = new AppDbContext())
            {
                var students = _context.Students
                    .Where(s => s.SectionId == this.CurrentSectionId)
                    .OrderBy(s => s.LastName).ThenBy(s => s.FirstName)
                    .ToList();

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
                    UC_StudentRow studentRow = new UC_StudentRow();

                    studentRow.StudentId = student.Id;
                    studentRow.SectionId = this.CurrentSectionId;
                    studentRow.AttendanceDate = _selectedDate;

                    studentRow.StudentName = $"{student.FirstName} {student.LastName}";
                    studentRow.StudentNumber = count.ToString();

                    if (attendanceForDay.TryGetValue(student.Id, out var status))
                    {
                        studentRow.SetSelectedStatus(status);
                    }
                    else
                    {
                        studentRow.SetSelectedStatus(null);
                    }

                    layoutStudents.Controls.Add(studentRow);
                    count++;
                }

                lblNumberofStudents.Text = $"{students.Count} Students";
            }

            SetSummaryCards();
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {
            UpdateDateDisplay();

            if (CurrentSectionId != 0)
            {
                LoadSectionInfo();
                LoadStudentsForDate();
            }
        }

        private void lblBackToClass_Click(object sender, EventArgs e)
        {
            var mainForm = this.FindForm() as Main_Screen_Form;
            if (mainForm == null)
                return;

            if (CallerControl != null)
            {
                mainForm.loadForm(CallerControl);
            }
            else
            {
                mainForm.loadForm(new UC_Classes());
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
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnMarkAllPresent error: " + ex);
            }

            LoadStudentsForDate();
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
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnReset error: " + ex);
            }

            LoadStudentsForDate();
            SetSummaryCards();
        }

        public void RefreshSummaryAndRoster()
        {
            LoadStudentsForDate();
            SetSummaryCards();
        }

        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            if (CurrentSectionId == 0)
            {
                MessageBox.Show("No section selected to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Form_AttendanceSummary summaryForm = new Form_AttendanceSummary(CurrentSectionId))
            {
                summaryForm.ShowDialog();
            }
        }

        private void kryptonCustomPaletteBase1_PalettePaint(object sender, Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }
    }
}
