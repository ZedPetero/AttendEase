using Brevi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;

namespace Brevi.Application
{
    public partial class UCEditTeacher : UserControl
    {
        private readonly ITeacherService _teacherService;
        private Teacher? _currentTeacher;
        private byte[]? _uploadedImageBytes = null;
        public UCEditTeacher(ITeacherService teacherService)
        {
            InitializeComponent();
            _teacherService = teacherService;
            LoadTeacherData();
        }

        private async Task LoadTeacherData()
        {
            var allSubjects = await _teacherService.GetAllSubjectsAsync();
            cmbSubject.DataSource = allSubjects;
            cmbSubject.DisplayMember = "Name";
            cmbSubject.ValueMember = "Id";
        
            _currentTeacher = await _teacherService.GetTeacherByIdAsync(UserSession.CurrentTeacherId);
            if (_currentTeacher != null)
            {
                kryptonLabel2.Text = $"Editing Profile: {_currentTeacher.FirstName ?? ""} {_currentTeacher.LastName ?? ""}";
                kryptonLabel3.Text = _currentTeacher.Subject?.Name ?? "No Subject";
                txtFirstName.Text = _currentTeacher.FirstName ?? "";
                txtMiddleName.Text = _currentTeacher.MiddleName ?? "";
                txtLastName.Text = _currentTeacher.LastName ?? "";
                txtEmail.Text = _currentTeacher.Email ?? "";
                datePickerDate.Value = _currentTeacher.Birthday.HasValue
                                        ? _currentTeacher.Birthday.Value.ToDateTime(TimeOnly.MinValue)
                                        : DateTime.Now;
                cmbSubject.Text = _currentTeacher.Subject?.Name ?? "";
                txtPhoneNum.Text = _currentTeacher.PhoneNumber ?? "";
                txtBio.Text = _currentTeacher.Bio ?? "";
                if (_currentTeacher.ProfilePicture != null && _currentTeacher.ProfilePicture.Length > 0)
                {
                    using var ms = new System.IO.MemoryStream(_currentTeacher.ProfilePicture);
                    Image profilePic = Image.FromStream(ms);
                    btnUploadPicture.StateCommon.Back.Image = profilePic;
                    btnUploadPicture.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                    btnUploadPicture.Values.Text = "";
                }
            }
        }
        public async Task<bool> SaveTeacherDataAsync()
        {
            if (_currentTeacher == null) return false;

            try
            {
                // Map UI to Model
                _currentTeacher.FirstName = txtFirstName.Text;
                _currentTeacher.LastName = txtLastName.Text;
                _currentTeacher.Email = txtEmail.Text;
                _currentTeacher.PhoneNumber = txtPhoneNum.Text;
                _currentTeacher.Bio = txtBio.Text;
                _currentTeacher.Birthday = DateOnly.FromDateTime(datePickerDate.Value);

                // Handle Subject Logic
                string subjectName = cmbSubject.Text.Trim();
                var existingSubject = await _teacherService.GetSubjectByNameAsync(subjectName);

                if (existingSubject != null)
                    _currentTeacher.SubjectId = existingSubject.Id;
                else
                    _currentTeacher.SubjectId = (await _teacherService.CreateSubjectAsync(subjectName)).Id;

                if (_uploadedImageBytes != null)
                    _currentTeacher.ProfilePicture = _uploadedImageBytes;

                // Save via Service
                bool success = await _teacherService.UpdateTeacherProfileAsync(_currentTeacher);

                if (success)
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return success;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Profile Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image profilePic = Image.FromFile(openFileDialog.FileName);

                    btnUploadPicture.StateCommon.Back.Image = profilePic;
                    btnUploadPicture.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                    btnUploadPicture.Values.Text = "";

                    _uploadedImageBytes = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                }
            }
        }
    }
}
