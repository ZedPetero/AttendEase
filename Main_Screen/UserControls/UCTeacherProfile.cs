using Brevi.Infrastructure.Data;
using Brevi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Brevi.Services.Repositories.IRepositories;

namespace Brevi.Application
{
    public partial class UCTeacherProfile : UserControl
    {
        private readonly ITeacherService _teacherService;
        public UCTeacherProfile(ITeacherService teacherService)
        {
            InitializeComponent();
            _teacherService = teacherService;
            UIHelper.RoundControl(this, 20);
            UIHelper.RoundControl(panel1, 20);
        }
        public async Task LoadTeacherProfileAsync()
        {
            if (UserSession.CurrentTeacherId == 0) return;

            try
            {
                if (UserSession.CurrentTeacherId == 0)
                {
                    MessageBox.Show("Debug: CurrentTeacherId is 0. Login session might be missing.");
                    return;
                }
                var teacher = await _teacherService.GetTeacherByIdAsync(UserSession.CurrentTeacherId);
                if (teacher == null)
                {
                    MessageBox.Show($"Debug: No teacher found in database with ID {UserSession.CurrentTeacherId}");
                    return;
                }
                if (teacher != null)
                {
                    lblTeacherTitle.Text = $"{teacher.FirstName} {teacher.LastName}";
                    lblTeacherName.Text = $"{teacher.FirstName} {teacher.LastName}";
                    lblEmail.Text = teacher.Email;
                    lblPhoneNum.Text = teacher.PhoneNumber;

                    if (teacher.ProfilePicture != null && teacher.ProfilePicture.Length > 0)
                    {
                        try
                        {
                            using (var ms = new System.IO.MemoryStream(teacher.ProfilePicture))
                            {
                                using (var tempImage = Image.FromStream(ms))
                                {
                                    Bitmap profilePic = new Bitmap(tempImage);

                                    btnProfilePic.StateCommon.Back.Image = profilePic;
                                    btnProfilePic.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                                    btnProfilePic.Values.Text = "";
                                }
                            }
                        }
                        catch (Exception imgEx)
                        {
                            System.Diagnostics.Debug.WriteLine($"Image Rendering Error: {imgEx.Message}");
                        }
                    }

                    lblSubject.Text = teacher.Subject?.Name ?? "N/A";
                    lblSubjectTitle.Text = teacher.Subject?.Name ?? "N/A";
                    lblBirthdate.Text = teacher.Birthday?.ToString("MMMM dd, yyyy") ?? "N/A";
                    lblWrapBio.Text = !string.IsNullOrEmpty(teacher.Bio) ? teacher.Bio : "N/A";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Profile Load Error: {ex.Message}");
            }
        }
        private async void UCTeacherProfile_Load(object sender, EventArgs e)
        {
            await LoadTeacherProfileAsync();
        }
    }
}
