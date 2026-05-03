using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brevi.Domain.Models
{
    public class Section
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SectionName { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
        public TimeSpan StartTimeSchedule { get; set; }
        public TimeSpan EndTimeSchedule { get; set; }
        public int TeacherId { get; set; } [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        // Indicates whether this section is archived
        public bool IsArchived { get; set; } = false;
    }
}