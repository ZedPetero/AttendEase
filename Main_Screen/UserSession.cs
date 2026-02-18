using System;
using System.Collections.Generic;
using System.Text;

namespace AE.Application
{
    public static class UserSession
    {
        // Default to 1 for testing, but the Login screen will update this later!
        public static int CurrentTeacherId { get; set; } = 1;

        public static string CurrentTeacherName { get; set; } = "Default Teacher";
    }
}