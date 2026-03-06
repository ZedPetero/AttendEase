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
            UIHelper.RoundControl(this, 20);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || comboSubject.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                string selectedSubjectName = comboSubject.SelectedItem.ToString();
                if (!Enum.TryParse(selectedSubjectName, out Subject selectedSubject))
                {
                    MessageBox.Show("Please fill in the class name and select a subject.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new AppDbContext())
                {
                    var section = new Section
                    {
                        SectionName = txtName.Text,
                        TeacherId = UserSession.CurrentTeacherId,
                        Subject = selectedSubject,
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
