using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Domain.Models
{
    public class AttendanceStats
    {
        public int PresentCount { get; set; }
        public int LateCount { get; set; }
        public int AbsentCount { get; set; }
        public int ExcusedCount { get; set; }
    }
}
