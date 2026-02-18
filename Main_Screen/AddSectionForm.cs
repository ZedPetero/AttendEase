using AE.Domain.Models;
using AE.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class AddSectionForm : Form
    {
        public AddSectionForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (var db = new AppDbContext())
            {
                var teacherExists = db.Teachers.Any(t => t.Id == 1);

                if (!teacherExists)
                {
                    var defaultTeacher = new AE.Domain.Models.Teacher
                    {
                        FirstName = "Default",
                        LastName = "Teacher",
                    };

                    db.Teachers.Add(defaultTeacher);
                    db.SaveChanges(); 
                }
                var section = new Section
                {
                    SectionName = txtName.Text,
                    Subject = txtSubject.Text,
                    TimeSchedule = txtTime.Text,
                    TeacherId = UserSession.CurrentTeacherId,
                };

                db.Sections.Add(section);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
