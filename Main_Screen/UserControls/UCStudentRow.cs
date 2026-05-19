using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Brevi.Infrastructure.Data;
using Brevi.Domain.Models;
using System.Diagnostics;
using Brevi.Services.Repositories.IRepositories;

namespace Brevi.Application
{
    public partial class UCStudentRow : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int StudentId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int SectionId { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public DateTime AttendanceDate { get; set; } = DateTime.Today;

        private AttendanceStatus? _selectedStatus;

        public event EventHandler<int> AttendanceStatusChanged;
        private readonly IAttendanceService _attendanceService;
        private readonly IStudentService _studentService;
        public UCStudentRow(IAttendanceService attendanceService, IStudentService studentService)
        {
            _attendanceService = attendanceService;
            _studentService = studentService;
            InitializeComponent();
            FontEngine.RetargetAllFonts(this);
        }
        private void RoundPanel(object sender, EventArgs e)
        {
            if (sender is Control panel)
            {
                UIHelper.RoundControl(panel, 20);

                if (panel == this)
                {
                    pnlContent.Width = this.Width - 10;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentName
        {
            get { return lblStudentName.Text; }
            set { lblStudentName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentNumber
        {
            get { return lblNumber.Text; }
            set { lblNumber.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string StudentStatus
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public int Width1
        {
            get { return this.Width; }
            set { this.Width = value; }
        }
        public void SetSelectedStatus(AttendanceStatus? status)
        {
            _selectedStatus = status;

            if (status == null)
            {
                StudentStatus = "No Record";
                kryptonCheckSet1.CheckedButton = null;
                this.BackColor = Color.FromArgb(211, 215, 222);
                pnlContent.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                StudentStatus = status.ToString();

                switch (status)
                {
                    case AttendanceStatus.Present:
                        btnPresent.Checked = true;
                        this.BackColor = Color.FromArgb(224, 230, 235);
                        pnlContent.BackColor = Color.FromArgb(238, 247, 243);
                        break;
                    case AttendanceStatus.Late:
                        btnLate.Checked = true;
                        this.BackColor = Color.FromArgb(224, 230, 235);
                        pnlContent.BackColor = Color.FromArgb(248, 245, 239);
                        break;
                    case AttendanceStatus.Excused:
                        btnExcused.Checked = true;
                        this.BackColor = Color.FromArgb(224, 230, 235);
                        pnlContent.BackColor = Color.FromArgb(237, 245, 250);
                        break;
                    case AttendanceStatus.Absent:
                        btnAbsent.Checked = true;
                        this.BackColor = Color.FromArgb(223, 58, 58);
                        pnlContent.BackColor = Color.FromArgb(247, 240, 241);
                        break;
                }
            }
        }


        private void BtnPresent_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Present);
            AttendanceStatusChanged?.Invoke(this, StudentId);
        }

        private void BtnLate_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Late);
            AttendanceStatusChanged?.Invoke(this, StudentId);
        }

        private void BtnExcused_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Excused);
            AttendanceStatusChanged?.Invoke(this, StudentId);
        }

        private void BtnAbsent_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Absent);
            AttendanceStatusChanged?.Invoke(this, StudentId);
        }

        private async void BtnDeleteStudent_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show($"Delete {StudentName}?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _studentService.DeleteStudentAsync(StudentId);
                await FindParentAttendance()?.LoadStudentsForDateAsync();
            }
        }

        private async void SaveStatusAndRefresh(AttendanceStatus status)
        {
            if (StudentId == 0 || SectionId == 0) return;

            try
            {
                var record = new Attendance
                {
                    StudentId = StudentId,
                    SectionId = SectionId,
                    Date = AttendanceDate.Date,
                    Status = status,
                    Remarks = string.Empty
                };

                await _attendanceService.SaveAttendanceAsync(record);
                SetSelectedStatus(status);

                FindParentAttendance()?.RefreshSummaryAndRoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save: {ex.Message}");
            }
        }

        private UCAttendance FindParentAttendance()
        {
            Control c = this.Parent;
            while (c != null)
            {
                if (c is UCAttendance ua)
                    return ua;
                c = c.Parent;
            }
            return null;
        }
    }
}
