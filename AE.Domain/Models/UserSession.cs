using System;
using System.Collections.Generic;
using System.Text;

namespace AE.Application
{
    public static class UserSession
    {
        public static int CurrentTeacherId { get; set; } = 1;
        public static string CurrentTeacherName { get; set; } = "Default Teacher";
    }
}