using ExaminationSystem.Models;

namespace ExaminationSystem.Services
{
    public interface IExamService
    {
        Task<List<Exam>> GetAllExamsAsync();
        Task<int> GetTotalCoursesAsync();
        Task<int> GetTotalQuestionsAsync();
        Task DeleteExamAsync(Guid id);
    }
}
