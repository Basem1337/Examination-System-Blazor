using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Exam
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Exam title is required!")]
        [MinLength(2, ErrorMessage = "Exam title must be 2 characters at least")]
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        [Range(5,120, ErrorMessage = "Exam full mare must be between 5 to 120")]
        public int FullMark { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public Guid CourseId { get; set; }
        public Course? Course { get; set; } = null!;
    }
}
