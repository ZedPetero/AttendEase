using System;
using System.Collections.Generic;
using System.Text;

namespace AE.Application.DTO
{
    public class StudentSummaryDTO
    {
        public int StudentId {  get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
        public int Excused { get; set; }
        public string Score { get; set; }
        public double RawScore { get; set; }
    }
}
