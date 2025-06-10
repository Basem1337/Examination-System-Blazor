using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Services
{
    public class ExamService: IExamService
    {
        private readonly ApplicationDbContext _context;

        public ExamService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Exam>> GetAllExamsAsync()
        {
            return await _context.Exams
                .Include(e => e.Course)
                .Include(e => e.Questions)
                .ToListAsync();
        }

        public async Task<int> GetTotalCoursesAsync()
        {
            return await _context.Courses.CountAsync();
        }

        public async Task<int> GetTotalQuestionsAsync()
        {
            return await _context.Questions.CountAsync();
        }

        public async Task DeleteExamAsync(Guid id)
        {
            var exam = await _context.Exams.FindAsync(id);
            if (exam != null)
            {
                _context.Exams.Remove(exam);
                await _context.SaveChangesAsync();
            }
        }

    }
}
