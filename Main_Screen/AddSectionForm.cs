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
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSubject.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                using (var db = new AppDbContext())
                {
                    // Parse time from string
                    if (!DateTime.TryParse(txtTime.Text, out var timeSchedule))
                    {
                        MessageBox.Show("Invalid time format.");
                        return;
                    }
                    MessageBox.Show($"DEBUG: The current TeacherId being saved is: '{UserSession.CurrentTeacherId}'");
                    var section = new Section
                    {
                        SectionName = txtName.Text,
                        TeacherId = UserSession.CurrentTeacherId,
                        Subject = subjectEnum,
                        TimeSchedule = timeSchedule // Store as DateTime
                    };

                    db.Sections.Add(section);
                    db.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // 1. Grab the main message
                string errorMessage = "Main Error: " + ex.Message;

                // 2. Dig into the InnerException to find the real SQLite error!
                if (ex.InnerException != null)
                {
                    errorMessage += "\n\nReal Database Error (Inner Exception):\n" + ex.InnerException.Message;
                }

                // 3. Show it cleanly
                MessageBox.Show(errorMessage, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
