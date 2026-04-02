using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Brevi.Domain.Models
{
    public class Teacher : IdentityUser<int>
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public DateOnly? Birthday { get; set; }
        public Subject? Subject { get; set; }
        public string? Bio { get; set; }
        public List<Section> Sections { get; set; } = new();
    }
}