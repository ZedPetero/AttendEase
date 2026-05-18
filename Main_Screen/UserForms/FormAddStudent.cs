using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Brevi.Application
{
    public partial class FormAddStudent : Form
    {
        private readonly IStudentService _studentService;
        private readonly ISectionService _sectionService;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentSectionId { get; set; }
        public FormAddStudent(IStudentService studentService, ISectionService sectionService)
        {
            InitializeComponent();
            _studentService = studentService;
            _sectionService = sectionService;
            UIHelper.RoundControl(this, 20);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("First Name and Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var section = await _sectionService.GetSectionByIdAsync(this.CurrentSectionId);
                if (section == null)
                {
                    MessageBox.Show($"Error: Cannot add student. Section ID {this.CurrentSectionId} does not exist.");
                    return;
                }

                var student = new Student
                {
                    FirstName = txtFirstName.Text,
                    MiddleName = txtLastName.Text, // Note: You had MiddleName = txtLastName in original
                    LastName = txtLastName.Text,
                    SectionId = this.CurrentSectionId
                };

                await _studentService.AddAsync(student);

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
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

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            if (this.FindForm() != null)
            {
                this.FindForm().AcceptButton = btnSave;
            }
        }

        private void FormAddStudent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
