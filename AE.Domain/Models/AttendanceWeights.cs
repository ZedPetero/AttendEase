using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Domain.Models
{
    public class AttendanceWeights
    {
        public int Id { get; set; }
        public double PresentWeight { get; set; } = 1.0;
        public double LateWeight { get; set; } = 0.5;
        public double AbsentWeight { get; set; } = 0.0;
        public double ExcusedWeight { get; set; } = 1.0;
    }
}
