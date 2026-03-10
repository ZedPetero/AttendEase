using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AE.Domain.Models;
using AE.Infrastructure.Data;
using Krypton.Toolkit;
namespace AE.Application
{
    public partial class FormAddStudent : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentSectionId { get; set; }
        public FormAddStudent()
        {
            InitializeComponent();
            UIHelper.RoundControl(this, 20);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("First Name and Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var _context = new AppDbContext())
                {
                    bool sectionExists = _context.Sections.Any(s => s.Id == this.CurrentSectionId);

                    if (!sectionExists)
                    {
                        MessageBox.Show($"Error: Cannot add student. Section ID {this.CurrentSectionId} does not exist in the database.");
                        return;
                    }
                    var student = new Student
                    {
                        FirstName = txtFirstName.Text,
                        MiddleName = txtLastName.Text,
                        LastName = txtLastName.Text,
                        SectionId = this.CurrentSectionId
                    };
                    _context.Students.Add(student);
                    _context.SaveChanges();
                }
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
