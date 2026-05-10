using Brevi.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories
{
    public class SettingsServices
    {
        private readonly UserManager<TeacherService> _userManager;

        public SettingsServices(UserManager<TeacherService> userManager)
        {
            _userManager = userManager;
        }

        //public List<string> GetAttendanceWeights()
        //{
        //    return _userManager.Users
        //        .Select(u => u.)
        //}

    }
}
