using AE.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AE.Domain.Models;

namespace AE.Application
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
                var teacher = context.Teachers.FirstOrDefault(); 
                if (teacher != null)
                {
                    kryptonLabel2.Text = $"Editing Profile: {teacher.FirstName} {teacher.LastName}";
                    kryptonLabel3.Text = teacher.Subject.ToString();
                    txtFirstName.Text = teacher.FirstName;
                    txtMiddleName.Text = teacher.MiddleName;
                    txtLastName.Text = teacher.LastName;
                    txtEmail.Text = teacher.Email;
                    datePickerDate.Value = teacher.Birthday.HasValue
                                            ? teacher.Birthday.Value.ToDateTime(TimeOnly.MinValue)
                                            : DateTime.Now;
                    cmbSubject.SelectedItem = teacher.Subject.ToString();
                    txtPhoneNum.Text = teacher.PhoneNumber;
                    txtBio.Text = teacher.Bio;
                    var ms = new System.IO.MemoryStream(teacher.ProfilePicture);
                    Image profilePic = Image.FromStream(ms);
                    btnUploadPicture.StateCommon.Back.Image = profilePic;
                    btnUploadPicture.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                    btnUploadPicture.Values.Text = "";
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
                        teacher.Subject = Enum.Parse<Subject>(cmbSubject.SelectedItem.ToString());
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
                MessageBox.Show("Error saving data: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
