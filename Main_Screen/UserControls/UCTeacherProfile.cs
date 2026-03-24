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

namespace Brevi.Application
{
    public partial class UCTeacherProfile : UserControl
    {
        public UCTeacherProfile()
        {
            InitializeComponent();
        }

        private async void UCTeacherProfile_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var teacher = await context.Teachers.FindAsync(UserSession.CurrentTeacherId);
                if (teacher != null)
                {
                    lblTeacherTitle.Text = $"{teacher.FirstName} {teacher.LastName}";
                    lblTeacherName.Text = $"{teacher.FirstName} {teacher.LastName}";
                    lblEmail.Text = teacher.Email;
                    lblPhoneNum.Text = teacher.PhoneNumber;
                    if (teacher.ProfilePicture != null)
                    {
                        var ms = new System.IO.MemoryStream(teacher.ProfilePicture);
                        Image profilePic = Image.FromStream(ms);
                        btnProfilePic.StateCommon.Back.Image = profilePic;
                        btnProfilePic.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
                        btnProfilePic.Values.Text = "";
                    }
                    if (teacher.Subject != null) 
                    {
                        lblSubject.Text = teacher.Subject.ToString();
                        lblSubjectTitle.Text = teacher.Subject.ToString();
                    }
                    else
                    {
                        lblSubject.Text = "N/A";
                        lblSubjectTitle.Text = "N/A";
                    }

                    if (teacher.Birthday.HasValue)
                    {
                        lblBirthdate.Text = teacher.Birthday.Value.ToString("MMMM dd, yyyy");
                    }
                    else
                    {
                        lblBirthdate.Text = "N/A";
                    }
                    if (!string.IsNullOrEmpty(teacher.Bio))
                    {
                        lblWrapBio.Text = teacher.Bio;
                    }
                    else
                    {
                        lblWrapBio.Text = "N/A";
                    }
                }
            }
        }
    }
}
