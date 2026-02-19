using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AE.Domain.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string MiddleName { get; set; }

        public int Age { get; set; }
        public int SectionId { get; set; } [ForeignKey("SectionId")]
        public Section Section { get; set; }
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public List<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}