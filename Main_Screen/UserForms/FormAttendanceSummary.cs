using Brevi.Application.DTO;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
        private readonly ISectionService _sectionService;
        private readonly IAttendanceService _attendanceService;
        private readonly IAttendanceWeightsService _weightsService;
        public FormAttendanceSummary(int sectionId, ISectionService sectionService, IAttendanceService attendanceService, IAttendanceWeightsService weightsService)
        {
            InitializeComponent();
            _sectionId = sectionId;
            _sectionService = sectionService;
            _attendanceService = attendanceService;
            _weightsService = weightsService;
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
        private async void Form_AttendanceSummary_Load(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
            try
            {
                await LoadSummaryDataAsync();
            }
            finally
            {
                SetControlsEnabled(true);
            }
        }
        private void SetControlsEnabled(bool enabled)
        {
            btnDownloadCSV.Enabled = enabled;
            gridSummary.Enabled = enabled;
        }
        private async Task LoadSummaryDataAsync()
        {

            var weights = await _weightsService.GetWeightsAsync();
            var students = await _sectionService.GetStudentsInSectionAsync(_sectionId);
            var allRecords = await _attendanceService.GetAllRecordsForSectionAsync(_sectionId);

            var summaryList = new List<StudentSummaryDTO>();
            int counter = 1;

            foreach (var student in students)
            {
                var records = allRecords.Where(a => a.StudentId == student.Id).ToList();

                int total = records.Count;
                int p = records.Count(r => r.Status == AttendanceStatus.Present);
                int l = records.Count(r => r.Status == AttendanceStatus.Late);
                int a = records.Count(r => r.Status == AttendanceStatus.Absent);
                int ex = records.Count(r => r.Status == AttendanceStatus.Excused);

                double points = (p * weights.PresentWeight)
                              + (ex * weights.ExcusedWeight)
                              + (l * weights.LateWeight)
                              + (a * weights.AbsentWeight);

                double finalPercentage = total > 0 ? (points / total) * 100.0 : 0;

                string middleInitial = string.IsNullOrWhiteSpace(student.MiddleName)
                    ? ""
                    : $" {student.MiddleName[0].ToString().ToUpper()}.";

                summaryList.Add(new StudentSummaryDTO
                {
                    StudentId = student.Id,
                    RollNo = counter.ToString("D3"),
                    Name = $"{student.LastName}, {student.FirstName}{middleInitial}",
                    Days = total,
                    Present = p,
                    Late = l,
                    Absent = a,
                    Excused = ex,
                    RawScore = finalPercentage,
                    Score = $"{Math.Round(finalPercentage)}/100"
                });
                counter++;
            }

            _summaryData = summaryList;

            // Bind on the UI thread (we're already on it since Load is a UI event)
            gridSummary.DataSource = _summaryData;
            gridSummary.Columns["RawScore"].Visible = false;

            string[] centerCols = { "Days", "Present", "Late", "Absent", "Excused", "Score" };
            foreach (var col in centerCols)
                gridSummary.Columns[col].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            scoreCalculationLabel.Text =
                $"Score calculation: Present = {weights.PresentWeight * 100}%, " +
                $"Late = {weights.LateWeight * 100}%, " +
                $"Absent = {weights.AbsentWeight * 100}%, " +
                $"Excused = {weights.ExcusedWeight * 100}%";
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

        private async void btnDownloadCSV_Click(object sender, EventArgs e)
        {
            if (_summaryData == null || _summaryData.Count == 0)
            {
                MessageBox.Show("No data found to export.", "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|PDF Files (*.pdf)|*.pdf",
                Title = "Save Attendance Summary",
                FileName = $"Attendance_Summary_{DateTime.Now:yyyy-MM-dd}"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            string ext = Path.GetExtension(sfd.FileName).ToLower();

            if (ext == ".csv")
                await ExportToCSVAsync(sfd.FileName);
            else if (ext == ".pdf")
                ExportToPDF(sfd.FileName);
        }
        private async Task ExportToCSVAsync(string filePath)
        {
            try
            {
                var allRecords = await _attendanceService.GetAllRecordsForSectionAsync(_sectionId);
                var uniqueDates = allRecords.Select(a => a.Date.Date).Distinct().OrderBy(d => d).ToList();

                var sb = new StringBuilder();
                var header = new StringBuilder("Roll No,Name,Days,Present,Late,Absent,Excused,Score");
                foreach (var date in uniqueDates) header.Append($",{date:MMM dd yyyy}");
                sb.AppendLine(header.ToString());

                foreach (var row in _summaryData)
                {
                    var line = new StringBuilder(
                        $"{row.RollNo},\"{row.Name}\",{row.Days},{row.Present}," +
                        $"{row.Late},{row.Absent},{row.Excused},{row.Score}");

                    var studentRecords = allRecords.Where(a => a.StudentId == row.StudentId).ToList();
                    foreach (var date in uniqueDates)
                    {
                        var rec = studentRecords.FirstOrDefault(a => a.Date.Date == date);
                        line.Append(rec != null ? $",{rec.Status}" : ",-");
                    }
                    sb.AppendLine(line.ToString());
                }

                await File.WriteAllTextAsync(filePath, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("CSV exported successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("CSV Error: " + ex.Message);
            }
        }
        private void ExportToPDF(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (iText.Layout.Document document = new iText.Layout.Document(pdf))
                {
                    var bold = iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD;
                    var fontBold = iText.Kernel.Font.PdfFontFactory.CreateFont(bold);

                    iText.Layout.Element.Paragraph header = new iText.Layout.Element.Paragraph("Attendance Summary")
                        .SetFontSize(18)
                        .SetFont(fontBold);

                    document.Add(header);
                    document.Add(new iText.Layout.Element.Paragraph($"Generated on: {DateTime.Now:f}"));

                    Table table = new Table(iText.Layout.Properties.UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

                    string[] headers = { "Roll No", "Name", "Days", "Pres", "Late", "Abs", "Exc", "Score" };
                    foreach (var h in headers)
                    {
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