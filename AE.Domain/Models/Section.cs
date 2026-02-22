using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AE.Domain.Models
{
    public class Section
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string SectionName { get; set; } 
        public Subject Subject { get; set; } 
        public DateTime TimeSchedule { get; set; }
        public int TeacherId { get; set; } [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        // Indicates whether this section is archived
        public bool IsArchived { get; set; } = false;
    }
}