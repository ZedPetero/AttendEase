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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
        }

        private void LoadSummaryData()
        {
            var summaryList = new List<StudentSummaryDTO>();

            using (var db = new AppDbContext())
            {
                var weights = db.AttendanceWeights.FirstOrDefault() ?? new AttendanceWeights();
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

                    double points = (p * weights.PresentWeight) +
                            (e * weights.ExcusedWeight) +
                            (l * weights.LateWeight) +
                            (a * weights.AbsentWeight);
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

                scoreCalculationLabel.Text = "Score calculation: Present = " 
                    + weights.PresentWeight*100 + "%, Late = "
                    + weights.LateWeight*100 + "%, Absent = "
                    + weights.AbsentWeight*100 + "%, Excused = "
                    + weights.ExcusedWeight*100 + "%";
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
                // Added PDF to the filter
                sfd.Filter = "CSV Files (*.csv)|*.csv|PDF Files (*.pdf)|*.pdf";
                sfd.Title = "Save Attendance Summary";
                sfd.FileName = $"Attendance_Summary_{DateTime.Now:yyyy-MM-dd}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string extension = Path.GetExtension(sfd.FileName).ToLower();

                    if (extension == ".csv")
                    {
                        ExportToCSV(sfd.FileName);
                    }
                    else if (extension == ".pdf")
                    {
                        ExportToPDF(sfd.FileName);
                    }
                }
            }
        }
        private void ExportToCSV(string filePath)
        {
            try
            {
                using var db = new AppDbContext();
                var allSectionAttendance = db.AttendanceRecords.Where(a => a.SectionId == _sectionId).ToList();
                var uniqueDates = allSectionAttendance.Select(a => a.Date.Date).Distinct().OrderBy(d => d).ToList();

                var sb = new StringBuilder();
                var headerBuilder = new StringBuilder("Roll No,Name,Days,Present,Late,Absent,Excused,Score");
                foreach (var date in uniqueDates) headerBuilder.Append($",{date:MMM dd yyyy}");
                sb.AppendLine(headerBuilder.ToString());

                foreach (var row in _summaryData)
                {
                    var rowBuilder = new StringBuilder($"{row.RollNo},\"{row.Name}\",{row.Days},{row.Present},{row.Late},{row.Absent},{row.Excused},{row.Score}");
                    var studentRecords = allSectionAttendance.Where(a => a.StudentId == row.StudentId).ToList();

                    foreach (var date in uniqueDates)
                    {
                        var recordForDate = studentRecords.FirstOrDefault(a => a.Date.Date == date);
                        rowBuilder.Append(recordForDate != null ? $",{recordForDate.Status}" : ",-");
                    }
                    sb.AppendLine(rowBuilder.ToString());
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("CSV exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("CSV Error: " + ex.Message); }
        }
        private void ExportToPDF(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (iText.Layout.Document document = new iText.Layout.Document(pdf))
                {
                    // Use the "SetProperty" method instead of "SetBold()" extension
                    // This is what SetBold() does behind the scenes
                    var bold = iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD;
                    var fontBold = iText.Kernel.Font.PdfFontFactory.CreateFont(bold);

                    iText.Layout.Element.Paragraph header = new iText.Layout.Element.Paragraph("Attendance Summary")
                        .SetFontSize(18)
                        .SetFont(fontBold); // Manual Bold

                    document.Add(header);
                    document.Add(new iText.Layout.Element.Paragraph($"Generated on: {DateTime.Now:f}"));

                    Table table = new Table(iText.Layout.Properties.UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

                    string[] headers = { "Roll No", "Name", "Days", "Pres", "Late", "Abs", "Exc", "Score" };
                    foreach (var h in headers)
                    {
                        // Applying manual font to header cells
                        var cellPara = new iText.Layout.Element.Paragraph(h).SetFont(fontBold);
                        table.AddHeaderCell(new Cell().Add(cellPara));
                    }

                    foreach (var row in _summaryData)
                    {
                        table.AddCell(row.RollNo ?? "");
                        table.AddCell(row.Name ?? "");
                        table.AddCell(row.Days.ToString());
                        table.AddCell(row.Present.ToString());
                        table.AddCell(row.Late.ToString());
                        table.AddCell(row.Absent.ToString());
                        table.AddCell(row.Excused.ToString());
                        table.AddCell(row.Score ?? "");
                    }
                    document.Add(table);
                }
                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // This provides much more detail for debugging
                string detailedError = $"Message: {ex.Message}\n\n" +
                                       $"Inner Exception: {ex.InnerException?.Message}\n\n" +
                                       $"Stack Trace: {ex.StackTrace}";

                MessageBox.Show(detailedError, "PDF Debug Info");
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