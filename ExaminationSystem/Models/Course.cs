using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Course name is required!")]
        [MinLength(2, ErrorMessage = "Course name must be 2 characters at least")]
        public string Name { get; set; } = string.Empty;
        [Range(3,256, ErrorMessage = "Description must be between 3 and 256 characters")]
        public string Description { get; set; } = string.Empty;
        public Guid? ExamId { get; set; }
        public Exam? Exam { get; set; } = null!;
        public Guid InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!;
        public ICollection<StdCrs> StudentCourses { get; set; } = new List<StdCrs>();

    }
}
