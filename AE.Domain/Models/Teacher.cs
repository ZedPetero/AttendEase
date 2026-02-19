using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AE.Domain.Models
{
    public class Teacher : IdentityUser 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } 

        [Required]
        public string MiddleName { get; set; } 

        [Required]
        public string LastName { get; set; }

        public List<Section> Sections { get; set; } = new List<Section>();
    }
}