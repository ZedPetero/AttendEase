using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;
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

        private readonly ISectionService _sectionService;
        private readonly IAttendanceService _attendanceService;
        private readonly IGradeService _gradeService;
        private readonly IStudentService _studentService;
        private readonly IAttendanceWeightsService _attendanceWeightsService;
        private readonly IRepository<Subject> _subjectRepository;
        public UCAttendance(ISectionService sectionService, IAttendanceService attendanceService, IGradeService gradeService, IStudentService studentService, IAttendanceWeightsService attendanceWeightsService, IRepository<Subject> subjectRepository)
        {
            InitializeComponent();
            _sectionService = sectionService;
            _attendanceService = attendanceService;
            _gradeService = gradeService;
            _studentService = studentService;
            _subjectRepository = subjectRepository;
            _attendanceWeightsService = attendanceWeightsService;
            UpdateDateDisplay();
            SetSection(CurrentSectionId);
            FilterComboBox.SelectedIndexChanged += async (s, ev) => await LoadStudentsForDateAsync();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp; 
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public UserControl CallerControl { get; set; }

        private DateTime _selectedDate = DateTime.Today;
        private enum SortMethod { Surname, FirstName }
        private SortMethod _currentSort = SortMethod.Surname;

        public async void SetSection(int sectionId)
        {
            CurrentSectionId = sectionId;
            await LoadSectionInfoAsync();
            await LoadStudentsForDateAsync();
            await SetSummaryCardsAsync();
        }

        private void RoundPanel(object sender, EventArgs e)
        {
            if (sender is Control panel)
            {
                UIHelper.RoundControl(panel, 20);
            }
        }
        private async void UC_Attendance_Load(object sender, EventArgs e)
        {
            UpdateDateDisplay();

            if (CurrentSectionId != 0)
            {
                await LoadSectionInfoAsync();
                await LoadStudentsForDateAsync();
            }

            foreach (var panel in new Control[]
            {
                pnlTotalStudents, panelTotalBorder,
                pnlPresent,       panelPresentBorder,
                pnlLate,          panelLateBorder,
                pnlAbsent,        panelAbsentBorder,
                pnlExcused,       panelExcusedBorder,
                panelCalendar,    panelCalendarBorder
            })
            {
                UIHelper.RoundControl(panel, 20);
            }
        }
        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            using var popup = new FormAddStudent(_studentService, _sectionService)
            {
                CurrentSectionId = CurrentSectionId
            };

            var mainForm = this.FindForm() as MainScreenForm;
            mainForm?.ShowOverlay();
            popup.ShowDialog();
            mainForm?.HideOverlay();

            await LoadStudentsForDateAsync();
            await SetSummaryCardsAsync();
        }

        private async Task SetSummaryCardsAsync()
        {
            try
            {
                SuspendSummaryPanels();
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

                var students = await _sectionService.GetStudentsInSectionAsync(CurrentSectionId);
                int total = students.Count;

                var attendance = await _attendanceService
                    .GetRecordsForSectionAndDateAsync(CurrentSectionId, _selectedDate);

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

                pnlTotalStudents.ResumeLayout();
                pnlPresent.ResumeLayout();
                pnlLate.ResumeLayout();
                pnlAbsent.ResumeLayout();
                pnlExcused.ResumeLayout();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] SetSummaryCards error: " + ex);
            }
            finally
            {
                ResumeSummaryPanels();
            }
        }
        private void SuspendSummaryPanels()
        {
            pnlTotalStudents.SuspendLayout();
            pnlPresent.SuspendLayout();
            pnlLate.SuspendLayout();
            pnlAbsent.SuspendLayout();
            pnlExcused.SuspendLayout();
        }
        private void ResumeSummaryPanels()
        {
            pnlTotalStudents.ResumeLayout();
            pnlPresent.ResumeLayout();
            pnlLate.ResumeLayout();
            pnlAbsent.ResumeLayout();
            pnlExcused.ResumeLayout();
        }
        private async Task LoadSectionInfoAsync()
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
                var section = await _sectionService.GetSectionByIdAsync(CurrentSectionId);
                if (section != null)
                {
                    lblSectionName.Text = section.SectionName;
                    lblSubjectName.Text = section.Subject?.Name ?? "No Subject";
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

        public async Task LoadStudentsForDateAsync()
        {
            if (CurrentSectionId == 0)
            {
                lblNumberofStudents.Text = "0 Students";
                return;
            }

            Point scrollPos = layoutStudents.AutoScrollPosition;

            layoutStudents.SuspendLayout();
            layoutStudents.Controls.Clear();
            layoutStudents.FlowDirection = FlowDirection.TopDown;
            layoutStudents.WrapContents = false;
            layoutStudents.AutoScrollPosition = new Point(0, 0);

            try
            {
                var students = await _sectionService.GetStudentsInSectionAsync(CurrentSectionId);
                var attendance = await _attendanceService
                    .GetRecordsForSectionAndDateAsync(CurrentSectionId, _selectedDate);

                students = _currentSort == SortMethod.Surname
                    ? students.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList()
                    : students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();

                var attendanceForDay = attendance.ToDictionary(a => a.StudentId, a => a.Status);

                string selectedFilter = FilterComboBox.SelectedItem?.ToString() ?? "All";

                var filteredStudents = students.Where(student =>
                {
                    if (attendanceForDay.TryGetValue(student.Id, out var status))
                        return selectedFilter == "All" || status.ToString() == selectedFilter;
                    return selectedFilter == "All";
                }).ToList();

                int count = 1;
                foreach (var student in filteredStudents)
                {
                    var studentRow = new UCStudentRow(_attendanceService, _studentService)
                    {
                        StudentId = student.Id,
                        SectionId = CurrentSectionId,
                        AttendanceDate = _selectedDate,
                        StudentName = _currentSort == SortMethod.Surname
                            ? $"{student.LastName}, {student.FirstName}"
                            : $"{student.FirstName} {student.LastName}",
                        StudentNumber = count.ToString(),
                        Width1 = layoutStudents.ClientSize.Width - 10
                    };

                    studentRow.SetSelectedStatus(
                        attendanceForDay.TryGetValue(student.Id, out var s) ? s : (AttendanceStatus?)null);

                    studentRow.AttendanceStatusChanged +=
                        async (sender, id) => await StudentRow_AttendanceStatusChangedAsync(sender, id);

                    layoutStudents.Controls.Add(studentRow);
                    count++;
                }

                lblNumberofStudents.Text = $"{students.Count} Students";
            }
            finally
            {
                layoutStudents.ResumeLayout();
                layoutStudents.AutoScrollPosition =
                    new Point(Math.Abs(scrollPos.X), Math.Abs(scrollPos.Y));
            }
            _ = SetSummaryCardsAsync();
        }
        private async Task StudentRow_AttendanceStatusChangedAsync(object sender, int studentId)
        {
            await _gradeService.RecalculateGradeAsync(studentId, CurrentSectionId);
            await SetSummaryCardsAsync();
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
                mainForm.LoadForm(new UCClasses(_sectionService, _attendanceService, _gradeService, _studentService, _attendanceWeightsService, _subjectRepository));
            }
        }

        private void UpdateDateDisplay()
        {
            lblDateNow.Values.ExtraText = _selectedDate.ToString("D");

            if (btnNextDate != null)
            {
                btnNextDate.Enabled = _selectedDate.Date < DateTime.Today;
            }
        }

        private void lblDateNow_Click(object? sender, EventArgs e)
        {
            ShowCalendarPicker();
        }

        private async void btnNextDate_Click(object? sender, EventArgs e)
        {
            if (_selectedDate >= DateTime.Today)
            {
                MessageBox.Show("You cannot select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _selectedDate = _selectedDate.AddDays(1);
            UpdateDateDisplay();
            await LoadStudentsForDateAsync();
        }

        private async void btnPreviousDate_Click(object? sender, EventArgs e)
        {
            _selectedDate = _selectedDate.AddDays(-1);
            UpdateDateDisplay();
            await LoadStudentsForDateAsync();
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
                Location = new Point(5, 35),
                MaxDate = DateTime.Today
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

            cal.DateChanged += async (s, e) =>
            {
                if (isNavigating) return;

                _selectedDate = cal.SelectionStart.Date;
                UpdateDateDisplay();
                await LoadStudentsForDateAsync();
                dropDown.Close();
            };

            int offsetX = (lblDateNow.Width - container.Width) / 2;
            int offsetY = lblDateNow.Height + 4;

            dropDown.Show(lblDateNow, new Point(offsetX, offsetY));
        }

        private async void btnMarkAllPresent_Click(object? sender, EventArgs e)
        {
            if (CurrentSectionId == 0) return;

            try
            {
                await _attendanceService.MarkAllPresentAsync(CurrentSectionId, _selectedDate);

                var students = await _sectionService.GetStudentsInSectionAsync(CurrentSectionId);
                foreach (var student in students)
                    await _gradeService.RecalculateGradeAsync(student.Id, CurrentSectionId);

                foreach (Control control in layoutStudents.Controls)
                    if (control is UCStudentRow row)
                        row.SetSelectedStatus(AttendanceStatus.Present);

                await SetSummaryCardsAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnMarkAllPresent error: " + ex);
            }
        }

        private async void btnReset_Click(object? sender, EventArgs e)
        {
            if (CurrentSectionId == 0) return;

            if (MessageBox.Show(
                    "This will remove all attendance records for the selected date. Are you sure?",
                    "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                await _attendanceService.ResetAttendanceAsync(CurrentSectionId, _selectedDate);

                var students = await _sectionService.GetStudentsInSectionAsync(CurrentSectionId);
                foreach (var student in students)
                    await _gradeService.RecalculateGradeAsync(student.Id, CurrentSectionId);

                foreach (Control control in layoutStudents.Controls)
                    if (control is UCStudentRow row)
                        row.SetSelectedStatus(null);

                await SetSummaryCardsAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_Attendance] btnReset error: " + ex);
            }
        }

        public async void RefreshSummaryAndRoster()
        {
            await SetSummaryCardsAsync();
        }

        private void btnExportSummary_Click(object sender, EventArgs e)
        {
            if (CurrentSectionId == 0)
            {
                MessageBox.Show("No section selected to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormAttendanceSummary summaryForm = new FormAttendanceSummary(CurrentSectionId, _sectionService, _attendanceService, _attendanceWeightsService))
            {
                MainScreenForm mainForm = (MainScreenForm)this.FindForm();
                if (mainForm != null) mainForm.ShowOverlay();
                summaryForm.ShowDialog();
                if (mainForm != null) mainForm.HideOverlay();
            }
        }

        private async void btnSortSurname_Click(object sender, EventArgs e)
        {
            _currentSort = SortMethod.Surname;
            await LoadStudentsForDateAsync();
        }

        private async void btnSortFirstname_Click(object sender, EventArgs e)
        {
            _currentSort = SortMethod.FirstName;
            await LoadStudentsForDateAsync();
        }
        private void layoutStudents_SizeChanged(object sender, EventArgs e)
        {
            layoutStudents.SuspendLayout();
            int targetWidth = layoutStudents.ClientSize.Width - 11;
            foreach (Control ctrl in layoutStudents.Controls)
                if (ctrl is UCStudentRow)
                    ctrl.Width = targetWidth;
            layoutStudents.ResumeLayout();
        }
    }
}
