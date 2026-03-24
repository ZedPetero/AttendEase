using Brevi.Infrastructure.Data;
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
        public UCSectionCard()
        {
            InitializeComponent();
            originalMargin = this.Margin;
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

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var section = db.Sections.Where(b => b.Id == SectionId).FirstOrDefault();
                    if (section != null)
                    {
                        db.Remove(section);
                        db.SaveChanges();
                        MessageBox.Show("Section successfully deleted!");
                        SectionDeleted?.Invoke(this, SectionId);
                    }
                    else
                    {
                        MessageBox.Show("There is no such section!");
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error! \n" + ex.Message);
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
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);

            if (!this.ClientRectangle.Contains(mousePos))
            {
                isLifted = false;
                this.Margin = originalMargin;
            }
        }
    }
}
