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

namespace AE.Application
{
    public partial class UC_Attendance : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int CurrentSectionId { get; set; }

        // reference to the control that opened this attendance screen
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public UserControl CallerControl { get; set; }

        // currently selected date shown in the UI
        private DateTime _selectedDate = DateTime.Today;

        public UC_Attendance()
        {
            InitializeComponent();

            // wire UI interactions (designer didn't set these handlers)
            lblDateNow.Click += lblDateNow_Click;
            btnNextDate.Click += btnNextDate_Click;
            btnPreviousDate.Click += btnPreviousDate_Click;

            // Start with today's date visible
            UpdateDateDisplay();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (Form_AddStudent popup = new Form_AddStudent())
            {
                popup.CurrentSectionId = CurrentSectionId;
                var result = popup.ShowDialog();
                LoadStudentsForDate();
            }
        }

        private void LoadStudentsForDate()
        {
            layoutStudents.Controls.Clear();

            // Defensive: if section not set yet, do nothing
            if (CurrentSectionId == 0)
            {
                lblNumberofStudents.Text = "0 Students";
                return;
            }

            using (var _context = new AppDbContext())
            {
                // Get students in this section
                var students = _context.Students
                    .Where(s => s.SectionId == this.CurrentSectionId)
                    .OrderBy(s => s.LastName).ThenBy(s => s.FirstName)
                    .ToList();

                // Get attendance records for the selected date (between midnight and next midnight)
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

                    studentRow.StudentName = $"{student.FirstName} {student.LastName}";
                    studentRow.StudentNumber = count.ToString();

                    if (attendanceForDay.TryGetValue(student.Id, out var status))
                    {
                        studentRow.StudentStatus = status.ToString();
                    }
                    else
                    {
                        studentRow.StudentStatus = "No Record";
                    }

                    layoutStudents.Controls.Add(studentRow);
                    count++;
                }

                lblNumberofStudents.Text = $"{students.Count} Students";
            }
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {
            // Ensure the date label shows the right value and load students for that date.
            UpdateDateDisplay();
            LoadStudentsForDate();
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

        // --- Date / calendar interactions ---

        private void UpdateDateDisplay()
        {
            // Full day, month, day, year format like "Saturday, February 14, 2026"
            lblDateNow.Text = _selectedDate.ToString("D");
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
            // Simple modal dialog that hosts a MonthCalendar and OK/Cancel buttons.
            using (var dlg = new Form())
            {
                dlg.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Width = 260;
                dlg.Height = 260;
                dlg.Text = "Choose date";

                var cal = new MonthCalendar
                {
                    MaxSelectionCount = 1,
                    Dock = DockStyle.Top,
                    SelectionStart = _selectedDate,
                    SelectionEnd = _selectedDate
                };

                var btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Dock = DockStyle.Left, Width = 120 };
                var btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Dock = DockStyle.Right, Width = 120 };

                var panel = new Panel { Dock = DockStyle.Bottom, Height = 40 };
                panel.Controls.Add(btnOk);
                panel.Controls.Add(btnCancel);

                dlg.Controls.Add(cal);
                dlg.Controls.Add(panel);

                // Show dialog and update date if user confirmed
                if (dlg.ShowDialog(this.FindForm()) == DialogResult.OK)
                {
                    _selectedDate = cal.SelectionStart.Date;
                    UpdateDateDisplay();
                    LoadStudentsForDate();
                }
            }
        }
    }
}
