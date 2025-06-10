using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExaminationSystem.Data;
using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public ICollection<StdCrs> StudentCourses { get; set; } = new List<StdCrs>();
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; } = default!;
        public ApplicationUser ApplicationUser { get; set; } = null!;

    }
}
