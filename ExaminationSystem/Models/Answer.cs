using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Answer text is required!")]
        [MinLength(2, ErrorMessage = "Answer text must be 2 characters at least")]
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }
        public Guid QuestionId { get; set; }
        public Question Question { get; set; } = null!;
    }
}
