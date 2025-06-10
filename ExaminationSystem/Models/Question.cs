using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Question text is required!")]
        [MinLength(2, ErrorMessage = "Question text must be 2 characters at least")]
        public string Text { get; set; } = string.Empty;
        [Required(ErrorMessage = "Question point is required!")]
        [Range(0, 100, ErrorMessage = "Point must be between 0 and 100")]
        public decimal Point { get; set; }
        public Guid ExamId { get; set; }
        public Exam Exam { get; set; } = null!;
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    }
}
