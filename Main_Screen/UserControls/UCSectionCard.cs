using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class UCSectionCard : UserControl
    {
        public int SectionId { get; private set; }
        public event EventHandler<int> TakeAttendanceClicked;
        public event EventHandler<int> SectionDeleted;
        private bool isLifted = false;
        private Padding originalMargin;
        private readonly ISectionService _sectionService;
        public UCSectionCard(ISectionService sectionService)
        {
            _sectionService = sectionService;
            InitializeComponent();
            UIHelper.RoundControl(panel1, 10);
            UIHelper.RoundControl(this, 16);
            originalMargin = this.Margin;
            BindHoverEvents(this);
        }
        private void BindHoverEvents(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseEnter += Card_MouseEnter;
                c.MouseLeave += Card_MouseLeave;
                if (c.HasChildren) BindHoverEvents(c);
            }
        }
        public void SetData(int sectionId, string sectionName, string subject, int studentCount, string timeSchedule)
        {
            SectionId = sectionId;
            lblSectionName.Text = sectionName;
            lblSubjectName.Text = subject;
            lblNumOfStudents.Values.ExtraText = $"{studentCount} students";
            lblTime.Text = timeSchedule;
        }
        private void btnTakeAttendance_Click_1(object sender, EventArgs e)
        {
            TakeAttendanceClicked?.Invoke(this, SectionId);
        }

        private async void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this section?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            try
            {
                bool deleted = await _sectionService.DeleteSectionAsync(SectionId);
                if (deleted)
                {
                    MessageBox.Show("Section deleted!");
                    SectionDeleted?.Invoke(this, SectionId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            if (!isLifted)
            {
                isLifted = true;

                this.Margin = new Padding(
                    originalMargin.Left,
                    originalMargin.Top - 5,
                    originalMargin.Right,
                    originalMargin.Bottom + 5);

                this.Invalidate(); // Force a redraw
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            if (!this.DisplayRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                isLifted = false;
                this.Margin = originalMargin;
                this.Invalidate();
            }
        }
    }
}
