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

namespace Brevi.Application
{
    public partial class UCEditTeacher : UserControl
    {
        private byte[]? _uploadedImageBytes = null;
        public UCEditTeacher()
        {
            InitializeComponent();
            LoadTeacherData();
        }

        private void LoadTeacherData()
        {
            using (var context = new AppDbContext())
            {
                var allSubjects = context.Subjects.ToList();
                cmbSubject.DataSource = allSubjects;
                cmbSubject.DisplayMember = "Name";
                cmbSubject.ValueMember = "Id";    

                var teacher = context.Teachers.Include(t => t.Subject).FirstOrDefault();
                if (teacher != null)
                {
                    kryptonLabel2.Text = $"Editing Profile: {teacher.FirstName ?? ""} {teacher.LastName ?? ""}";
                    kryptonLabel3.Text = teacher.Subject?.Name ?? "No Subject";
                    txtFirstName.Text = teacher.FirstName ?? "";
                    txtMiddleName.Text = teacher.MiddleName ?? "";
                    txtLastName.Text = teacher.LastName ?? "";
                    txtEmail.Text = teacher.Email ?? "";
                    datePickerDate.Value = teacher.Birthday.HasValue
                                            ? teacher.Birthday.Value.ToDateTime(TimeOnly.MinValue)
                                            : DateTime.Now;
                    cmbSubject.Text = teacher.Subject?.Name ?? "";
                    txtPhoneNum.Text = teacher.PhoneNumber ?? "";
                    txtBio.Text = teacher.Bio ?? "";
                    if (teacher.ProfilePicture != null && teacher.ProfilePicture.Length > 0)
                    {
                        var ms = new System.IO.MemoryStream(teacher.ProfilePicture);
                        Image profilePic = Image.FromStream(ms);
                        btnUploadPicture.StateCommon.Back.Image = profilePic;
                        btnUploadPicture.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                        btnUploadPicture.Values.Text = "";
                    }
                }
            }
        }
        public bool SaveTeacherData()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var teacher = context.Teachers.FirstOrDefault();

                    if (teacher != null)
                    {
                        teacher.FirstName = txtFirstName.Text;
                        teacher.MiddleName = txtMiddleName.Text;
                        teacher.LastName = txtLastName.Text;
                        teacher.Email = txtEmail.Text;
                        teacher.Birthday = DateOnly.FromDateTime(datePickerDate.Value);

                        string inputtedSubjectName = cmbSubject.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(inputtedSubjectName))
                        {
                            var existingSubject = context.Subjects
                                .FirstOrDefault(s => s.Name.ToLower() == inputtedSubjectName.ToLower());

                            if (existingSubject != null)
                            {
                                teacher.SubjectId = existingSubject.Id;
                            }
                            else
                            {
                                var newSubject = new Subject { Name = inputtedSubjectName };
                                context.Subjects.Add(newSubject);
                                context.SaveChanges(); 

                                teacher.SubjectId = newSubject.Id;
                            }
                        }

                        teacher.PhoneNumber = txtPhoneNum.Text;
                        teacher.Bio = txtBio.Text;
                        if (_uploadedImageBytes != null)
                        {
                            teacher.ProfilePicture = _uploadedImageBytes;
                        }

                        context.SaveChanges();
                        MessageBox.Show("Teacher profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Failed to save profile.\n\nError: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
