using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Domain.DTO
{
    public class SectionDto
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string SubjectName { get; set; }
        public int StudentCount { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
