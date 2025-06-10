namespace ExaminationSystem.Models
{
    public class StdCrs
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; } = null!;
        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public decimal? Grade { get; set; }
    }
}
