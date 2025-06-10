using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExaminationSystem.Data;
using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Models
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; } = default!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
