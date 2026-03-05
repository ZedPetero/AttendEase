using AE.Infrastructure.Data;
using AE.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AE.Application
{
    public partial class UCTeacherProfile : UserControl
    {
        public UCTeacherProfile()
        {
            InitializeComponent();
        }

        private /*async*/ void UCTeacherProfile_Load(object sender, EventArgs e)
        {
            //using (var context = new AppDbContext())
            //{
            //    var teacher = await context.Teachers.FirstOrDefaultAsync(t => t.Email == );
            //    if (teacher != null)
            //    {
            //        lblTeacherName.Text = $"{teacher.FirstName} {teacher.LastName}";
            //        lblEmail.Text = teacher.Email;
            //        lblPhoneNum.Text = teacher.PhoneNumber;
            //    }
            //}
        }
    }
}
