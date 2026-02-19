using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AE.Domain.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Subject Subject { get; set; } 
        public double Score { get; set; } 
        public int StudentId { get; set; } [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}