using Brevi.Domain.Models;
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
    public partial class AddSectionForm : Form
    {
        private readonly ISectionService _sectionService;
        private readonly IRepository<Subject> _subjectRepository;

        public AddSectionForm(ISectionService sectionService, IRepository<Subject> subjectRepository)
        {
            InitializeComponent();
            _sectionService = sectionService;
            _subjectRepository = subjectRepository;
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(comboSubject, 10);
            UIHelper.RoundControl(txtName, 10);
            UIHelper.RoundControl(dateTimeStarting, 10);
            UIHelper.RoundControl(dateTimeEnding, 10);
        }
        private async Task LoadExistingSubjectsAsync()
        {
            try
            {
                var allSubjects = await _subjectRepository.GetAllAsync();
                comboSubject.DataSource = allSubjects;
                comboSubject.DisplayMember = "Name";
                comboSubject.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load subjects: " + ex.Message);
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(comboSubject.Text))
                {
                    MessageBox.Show("Please fill in the class name and select or type a subject.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedSubjectName = comboSubject.Text.Trim();
                var subjects = await _subjectRepository.GetAllAsync();
                var existingSubject = subjects.FirstOrDefault(s => s.Name.Equals(selectedSubjectName, StringComparison.OrdinalIgnoreCase));
                int subjectIdToLink;

                if (existingSubject != null)
                {
                    subjectIdToLink = existingSubject.Id;
                }
                else
                {
                    var newSubject = new Subject { Name = selectedSubjectName };
                    await _subjectRepository.AddAsync(newSubject);
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
                await _sectionService.AddAsync(section);
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

        private async void AddSectionForm_Load(object sender, EventArgs e)
        {
            if (this.FindForm() != null)
            {
                this.FindForm().AcceptButton = btnSaveClass;
            }
            await LoadExistingSubjectsAsync();
        }
    }
}
