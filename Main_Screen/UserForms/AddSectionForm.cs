using Brevi.Domain.Models;
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
    public partial class AddSectionForm : Form
    {
        

        public AddSectionForm()
        {
            InitializeComponent();
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(comboSubject, 10);
            UIHelper.RoundControl(txtName, 10);
            UIHelper.RoundControl(dateTimeStarting, 10);
            UIHelper.RoundControl(dateTimeEnding, 10);

            LoadExistingSubjects();
        }
        private void LoadExistingSubjects()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var allSubjects = db.Subjects.ToList();

                    comboSubject.DataSource = allSubjects;
                    comboSubject.DisplayMember = "Name"; 
                    comboSubject.ValueMember = "Id";     
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load subjects: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(comboSubject.Text))
                {
                    MessageBox.Show("Please fill in the class name and select or type a subject.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedSubjectName = comboSubject.Text.Trim();
                using (var db = new AppDbContext())
                {
                    int subjectIdToLink;
                    var existingSubject = db.Subjects.FirstOrDefault(s => s.Name.ToLower() == selectedSubjectName.ToLower());

                    if (existingSubject != null)
                    {
                        subjectIdToLink = existingSubject.Id; 
                    }
                    else
                    {
                        var newSubject = new Subject { Name = selectedSubjectName };
                        db.Subjects.Add(newSubject);
                        db.SaveChanges();
                        subjectIdToLink = newSubject.Id;
                    }
                    var section = new Section
                    {
                        SectionName = txtName.Text,
                        TeacherId = UserSession.CurrentTeacherId,
                        SubjectId = subjectIdToLink,
                        StartTimeSchedule = dateTimeStarting.Value.TimeOfDay,
                        EndTimeSchedule = dateTimeEnding.Value.TimeOfDay
                    };

                    db.Sections.Add(section);
                    db.SaveChanges();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string errorMessage = "Main Error: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nReal Database Error (Inner Exception):\n" + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
