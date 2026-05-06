using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Brevi.Application
{
    public partial class UC_RecordsClass : UserControl
    {
        private int _sectionId;
        private bool _isArchived = false;

        public void SetSection(int sectionId)
        {
            _sectionId = sectionId;
            LoadSection();
        }

        private void LoadSection()
        {
            try
            {
                classinfotable.Visible = false; 
                this.Height = 100;

                using var db = new Brevi.Infrastructure.Data.AppDbContext();

                var section = db.Sections
                    .Where(s => s.Id == _sectionId)
                    .Select(s => new { s.SectionName, SubjectName = s.Subject.Name }) 
                    .AsNoTracking()
                    .SingleOrDefault();

                if (section != null)
                {
                    lblClassName.Values.Text = section.SectionName;
                    lblSubject.Values.Text = section.SubjectName ?? "Unknown Subject";
                    lblClassName.AutoSize = true;
                    Size preferredSize = lblClassName.GetPreferredSize(new Size(0, 0));
                    int actualWidth = preferredSize.Width;

                    int margin = 15;
                    lblSubject.Location = new Point(lblClassName.Location.X + actualWidth + margin, lblSubject.Location.Y);

                    ArchiveorRestorebutton.Values.Text = _isArchived ? "" : "";
                    ArchiveorRestorebutton.Values.ExtraText = _isArchived ? "Restore" : "Archive";

                    classinfotable.Controls.Clear();
                    classinfotable.ColumnCount = 6;
                    classinfotable.ColumnStyles.Clear();
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // name
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // present
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // late
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // absent
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // excused (NEW)
                    classinfotable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // score

                    classinfotable.RowCount = 1;
                    classinfotable.RowStyles.Clear();
                    classinfotable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));

                    Font headerFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                    Color headerColor = Color.Gray;

                    AddCellToTable(0, 0, new Label { Text = "Name", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = headerFont, ForeColor = headerColor });
                    AddCellToTable(0, 1, new Label { Text = "Present", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = headerFont, ForeColor = headerColor });
                    AddCellToTable(0, 2, new Label { Text = "Late", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = headerFont, ForeColor = headerColor });
                    AddCellToTable(0, 3, new Label { Text = "Absent", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = headerFont, ForeColor = headerColor });
                    AddCellToTable(0, 4, new Label { Text = "Excused", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = headerFont, ForeColor = headerColor });
                    AddCellToTable(0, 5, new Label { Text = "Score", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = headerFont, ForeColor = headerColor });

                    var students = db.Students.Where(st => st.SectionId == _sectionId).ToList();

                    if (students.Count == 0)
                    {
                        classinfotable.RowCount = 2;
                        classinfotable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                        Label emptyStateLabel = new Label
                        {
                            Text = "No students enrolled in this class yet.",
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            ForeColor = Color.DimGray
                        };

                        classinfotable.Controls.Add(emptyStateLabel, 0, 1);
                        classinfotable.SetColumnSpan(emptyStateLabel, 6);

                        lblStudents.Values.ExtraText = "0 Students";
                        lblSessions.Values.Text = "0 Sessions";
                        lblAvgScore.Values.Text = "0%";
                    }
                    else
                    {
                        int row = 1;

                        int maxSessions = 0;
                        double totalClassScore = 0;
                        int studentsWithRecords = 0;

                        foreach (var student in students)
                        {
                            classinfotable.RowCount = row + 1;
                            classinfotable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));

                            AddCellToTable(row, 0, new Label { Text = $"{student.LastName}, {student.FirstName}", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft });

                            int present = db.AttendanceRecords.Count(a => a.StudentId == student.Id && a.Status == Brevi.Domain.Models.AttendanceStatus.Present);
                            int late = db.AttendanceRecords.Count(a => a.StudentId == student.Id && a.Status == Brevi.Domain.Models.AttendanceStatus.Late);
                            int absent = db.AttendanceRecords.Count(a => a.StudentId == student.Id && a.Status == Brevi.Domain.Models.AttendanceStatus.Absent);
                            int excused = db.AttendanceRecords.Count(a => a.StudentId == student.Id && a.Status == Brevi.Domain.Models.AttendanceStatus.Excused);

                            int total = present + late + absent + excused;
                            if (total > maxSessions) maxSessions = total;

                            Font statFont = new Font("Segoe UI", 9F, FontStyle.Bold);

                            AddCellToTable(row, 1, new Label { Text = present.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Green, Font = statFont });
                            AddCellToTable(row, 2, new Label { Text = late.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Goldenrod, Font = statFont });
                            AddCellToTable(row, 3, new Label { Text = absent.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Red, Font = statFont });
                            AddCellToTable(row, 4, new Label { Text = excused.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.Blue, Font = statFont });

                            string score = "-";
                            if (total > 0)
                            {
                                double studentPercentage = (present * 100.0) / total;
                                score = $"{studentPercentage:0}%";

                                totalClassScore += studentPercentage;
                                studentsWithRecords++;
                            }

                            AddCellToTable(row, 5, new Label { Text = score, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter, Font = statFont });

                            row++;
                        }

                        lblStudents.Values.ExtraText = $"{students.Count} Students";
                        lblSessions.Values.Text = $"{maxSessions} Sessions";

                        if (studentsWithRecords > 0)
                        {
                            double classAverage = totalClassScore / studentsWithRecords;
                            lblAvgScore.Values.Text = $"{classAverage:0}%";
                        }
                        else
                        {
                            lblAvgScore.Values.Text = "0%";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("UC_RecordsClass LoadSection error: " + ex.Message);
            }
        }

        private void AddCellToTable(int row, int col, Control ctrl)
        {
            ctrl.Margin = new Padding(3);
            classinfotable.Controls.Add(ctrl, col, row);
        }
        public UC_RecordsClass()
        {
            InitializeComponent();
            UIHelper.RoundControl(lblSubject, 20);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UIHelper.RoundControl(this, 20);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            classinfotable.Visible = !classinfotable.Visible;

            if (classinfotable.Visible)
            {
                sidebarbtn.Values.Text = "";
                this.Height = 350;
            }
            else
            {
                sidebarbtn.Values.Text = "";
                this.Height = 100;
            }

            this.Parent?.PerformLayout();
        }

        private void ArchiveorRestorebutton_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new Brevi.Infrastructure.Data.AppDbContext();
                var sec = db.Sections.Find(_sectionId);
                if (sec == null) return;

                sec.IsArchived = !sec.IsArchived;
                db.Sections.Update(sec);
                db.SaveChanges();

                var parent = this.FindForm();
                if (parent != null)
                {
                    var mainControl = FindParentRecordsNew();
                    if (mainControl != null)
                    {
                        if (sec.IsArchived)
                        {
                            mainControl.MoveToArchived(this);
                            ArchiveorRestorebutton.Values.Text = "";
                            ArchiveorRestorebutton.Values.ExtraText = "Restore";
                        }
                        else
                        {
                            mainControl.MoveToCurrent(this);
                            ArchiveorRestorebutton.Values.Text = "";
                            ArchiveorRestorebutton.Values.ExtraText = "Archive";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Archive toggle failed: " + ex.Message);
            }
        }

        private UC_Records_New FindParentRecordsNew()
        {
            Control p = this.Parent;
            while (p != null)
            {
                if (p is UC_Records_New rn)
                    return rn;
                p = p.Parent;
            }
            return null;
        }

        public void SetArchivedState(bool archived)
        {
            _isArchived = archived;

            ArchiveorRestorebutton.Values.ExtraText = archived ? "Restore" : "Archive";
            ArchiveorRestorebutton.Values.Text = archived ? "" : "";
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
