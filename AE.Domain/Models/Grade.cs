using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brevi.Domain.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Subject Subject { get; set; } 
        public int SectionId { get; set; } [ForeignKey("SectionId")]
        public double Percentage { get; set; } 
        public int StudentId { get; set; } [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}