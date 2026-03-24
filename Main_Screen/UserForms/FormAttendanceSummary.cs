using Brevi.Application.DTO;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class FormAttendanceSummary : Form
    {
        private readonly int _sectionId;
        private List<StudentSummaryDTO> _summaryData;

        public FormAttendanceSummary(int sectionId)
        {
            InitializeComponent();
            _sectionId = sectionId;
            UIHelper.RoundControl(pnlContent, 30);

            gridSummary.AutoGenerateColumns = false;

            gridSummary.Columns["RollNo"].DataPropertyName = "RollNo";
            gridSummary.Columns["Name"].DataPropertyName = "Name";
            gridSummary.Columns["Days"].DataPropertyName = "Days";
            gridSummary.Columns["Present"].DataPropertyName = "Present";
            gridSummary.Columns["Late"].DataPropertyName = "Late";
            gridSummary.Columns["Absent"].DataPropertyName = "Absent";
            gridSummary.Columns["Excused"].DataPropertyName = "Excused";
            gridSummary.Columns["Score"].DataPropertyName = "Score";
            gridSummary.Columns["RawScore"].DataPropertyName = "RawScore";

            gridSummary.CellPainting += gridSummary_CellPainting;
        }

        private void LoadSummaryData()
        {
            var summaryList = new List<StudentSummaryDTO>();

            using (var db = new AppDbContext())
            {
                var students = db.Students
                         .Where(s => s.SectionId == _sectionId)
                         .OrderBy(s => s.LastName)
                         .ThenBy(s => s.FirstName)
                         .ToList();

                var attendance = db.AttendanceRecords
                                   .Where(a => a.SectionId == _sectionId)
                                   .ToList();

                int counter = 1;
                foreach (var student in students)
                {
                    var records = attendance.Where(a => a.StudentId == student.Id).ToList();

                    int total = records.Count;
                    int p = records.Count(r => r.Status == AttendanceStatus.Present);
                    int l = records.Count(r => r.Status == AttendanceStatus.Late);
                    int a = records.Count(r => r.Status == AttendanceStatus.Absent);
                    int e = records.Count(r => r.Status == AttendanceStatus.Excused);

                    double points = (p * 1.0) + (e * 1.0) + (l * 0.5) + (a * 0.0);
                    double finalPercentage = total > 0 ? (points / total) * 100.0 : 0;

                    string middleInitial = string.IsNullOrWhiteSpace(student.MiddleName)
                                ? ""
                                : $" {student.MiddleName.Substring(0, 1).ToUpper()}.";
                    string fullName = $"{student.LastName}, {student.FirstName}{middleInitial}";

                    summaryList.Add(new StudentSummaryDTO
                    {
                        StudentId = student.Id,
                        RollNo = counter.ToString("D3"),
                        Name = fullName,
                        Days = total,
                        Present = p,
                        Late = l,
                        Absent = a,
                        Excused = e,
                        RawScore = finalPercentage,
                        Score = $"{Math.Round(finalPercentage)}/100"
                    });
                    counter++;
                }

                _summaryData = summaryList;
                gridSummary.DataSource = _summaryData;

                gridSummary.Columns["RawScore"].Visible = false;

                string[] numberCols = { "Days", "Present", "Late", "Absent", "Excused", "Score" };
                foreach (var col in numberCols)
                {
                    gridSummary.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void gridSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridSummary.Columns[e.ColumnIndex].Name == "Score" && e.Value != null)
            {
                var rowData = gridSummary.Rows[e.RowIndex].DataBoundItem as StudentSummaryDTO;

                if (rowData != null)
                {
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

                    if (rowData.RawScore >= 80)
                        e.CellStyle.ForeColor = Color.FromArgb(34, 197, 94);
                    else if (rowData.RawScore >= 50)
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11);
                    else
                        e.CellStyle.ForeColor = Color.FromArgb(239, 68, 68);
                }
            }
        }

        private void gridSummary_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                string colName = gridSummary.Columns[e.ColumnIndex].Name;
                Color textColor = Color.FromArgb(107, 114, 128);

                if (colName == "Present") textColor = Color.FromArgb(34, 197, 94);
                else if (colName == "Late") textColor = Color.FromArgb(245, 158, 11);
                else if (colName == "Absent") textColor = Color.FromArgb(239, 68, 68);
                else if (colName == "Excused") textColor = Color.FromArgb(59, 130, 246);

                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;
                if (colName == "RollNo" || colName == "Name")
                    flags |= TextFormatFlags.Left | TextFormatFlags.LeftAndRightPadding;
                else
                    flags |= TextFormatFlags.HorizontalCenter;

                TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(),
                    new Font("Segoe UI", 9.5F, FontStyle.Bold), e.CellBounds, textColor, flags);

                e.Handled = true;
            }
        }

        private void Form_AttendanceSummary_Load(object sender, EventArgs e)
        {
            LoadSummaryData();
        }

        private void btnDownloadCSV_Click(object sender, EventArgs e)
        {
            if (_summaryData == null || _summaryData.Count == 0)
            {
                MessageBox.Show("No data found to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.Title = "Save Attendance Summary";
                sfd.FileName = $"Attendance_Summary_{DateTime.Now:yyyy-MM-dd}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using var db = new AppDbContext();

                        var allSectionAttendance = db.AttendanceRecords
                            .Where(a => a.SectionId == _sectionId)
                            .ToList();

                        var uniqueDates = allSectionAttendance
                            .Select(a => a.Date.Date)
                            .Distinct()
                            .OrderBy(d => d)
                            .ToList();

                        var sb = new StringBuilder();

                        var headerBuilder = new StringBuilder("Roll No,Name,Days,Present,Late,Absent,Excused,Score");
                        foreach (var date in uniqueDates)
                        {
                            headerBuilder.Append($",{date.ToString("MMM dd yyyy")}");
                        }
                        sb.AppendLine(headerBuilder.ToString());

                        foreach (var row in _summaryData)
                        {
                            string safeName = $"\"{row.Name}\"";
                            var rowBuilder = new StringBuilder($"{row.RollNo},{safeName},{row.Days},{row.Present},{row.Late},{row.Absent},{row.Excused},{row.Score}");

                            var studentRecords = allSectionAttendance.Where(a => a.StudentId == row.StudentId).ToList();

                            foreach (var date in uniqueDates)
                            {
                                var recordForDate = studentRecords.FirstOrDefault(a => a.Date.Date == date);

                                if (recordForDate != null)
                                {
                                    rowBuilder.Append($",{recordForDate.Status.ToString()}");
                                }
                                else
                                {
                                    rowBuilder.Append(",-");
                                }
                            }

                            sb.AppendLine(rowBuilder.ToString());
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Successfully exported!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}