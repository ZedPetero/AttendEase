using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AE.Infrastructure.Data;
using AE.Domain.Models;
using System.Diagnostics;

namespace AE.Application
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

        public UCStudentRow()
        {
            InitializeComponent();
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(pnlContent, 20);
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

        private void UC_StudentRow_Load(object sender, EventArgs e)
        {
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(lblNumber, 18);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    UIHelper.RoundControl(c, 5);
                }
            }
        }

        public void SetSelectedStatus(AttendanceStatus? status)
        {
            _selectedStatus = status;

            if (status == null)
            {
                StudentStatus = "No Record";
                kryptonCheckSet1.CheckedButton = null;
            }
            else
            {
                StudentStatus = status.ToString();

                switch (status)
                {
                    case AttendanceStatus.Present:
                        btnPresent.Checked = true;
                        break;
                    case AttendanceStatus.Late:
                        btnLate.Checked = true;
                        break;
                    case AttendanceStatus.Excused:
                        btnExcused.Checked = true;
                        break;
                    case AttendanceStatus.Absent:
                        btnAbsent.Checked = true;
                        break;
                }
            }
        }


        private void BtnPresent_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Present);
        }

        private void BtnLate_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Late);
        }

        private void BtnExcused_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Excused);
        }

        private void BtnAbsent_Click(object? sender, EventArgs e)
        {
            SaveStatusAndRefresh(AttendanceStatus.Absent);
        }

        private void BtnDeleteStudent_Click(object? sender, EventArgs e)
        {
            if (StudentId == 0)
                return;

            var parentAttendance = FindParentAttendance();
            if (MessageBox.Show($"Delete student '{StudentName}'? This will remove the student and all their attendance records.",
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using var db = new AppDbContext();

                var student = db.Students.SingleOrDefault(s => s.Id == StudentId);
                if (student != null)
                {
                    var attendance = db.AttendanceRecords.Where(a => a.StudentId == StudentId).ToList();
                    if (attendance.Any())
                        db.AttendanceRecords.RemoveRange(attendance);

                    db.Students.Remove(student);
                    db.SaveChanges();
                }

                parentAttendance?.RefreshSummaryAndRoster();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_StudentRow] BtnDeleteStudent error: " + ex);
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveStatusAndRefresh(AttendanceStatus status)
        {
            if (StudentId == 0 || SectionId == 0)
                return;

            try
            {
                DateTime dateStart = AttendanceDate.Date;
                DateTime dateEnd = dateStart.AddDays(1);

                using var db = new AppDbContext();

                var existing = db.AttendanceRecords
                    .SingleOrDefault(a =>
                        a.StudentId == StudentId &&
                        a.SectionId == SectionId &&
                        a.Date >= dateStart && a.Date < dateEnd);

                if (existing == null)
                {
                    var record = new Attendance
                    {
                        StudentId = StudentId,
                        SectionId = SectionId,
                        Date = dateStart,
                        Status = status,
                        Remarks = string.Empty
                    };
                    db.AttendanceRecords.Add(record);
                }
                else
                {
                    existing.Status = status;
                }

                db.SaveChanges();

                SetSelectedStatus(status);

                var parentAttendance = FindParentAttendance();
                parentAttendance?.RefreshSummaryAndRoster();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[UC_StudentRow] SaveStatusAndRefresh error: " + ex);
                MessageBox.Show("Error saving attendance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
