using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace AE.Domain.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]  
        public string Username { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public List<Section> Sections { get; set; } = new List<Section>();
    }
}