using ExaminationSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace ExaminationSystem.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Student? StudentProfile { get; set; }
        public Instructor? InstructorProfile { get; set; }
    }

}
