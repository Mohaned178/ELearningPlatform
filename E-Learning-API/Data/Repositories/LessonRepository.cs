using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly ApplicationDbContext _context;

        public LessonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lesson> GetAll() => _context.Lessons.ToList();

        public IEnumerable<Lesson> GetByCourseId(int courseId) =>
            _context.Lessons.Where(l => l.CourseId == courseId).ToList();

        public Lesson GetById(int id) => _context.Lessons.Find(id);

        public void Add(Lesson lesson)
        {
            _context.Lessons.Add(lesson);
            _context.SaveChanges();
        }

        public void Update(Lesson lesson)
        {
            _context.Lessons.Update(lesson);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var lesson = _context.Lessons.Find(id);
            if (lesson != null)
            {
                _context.Lessons.Remove(lesson);
                _context.SaveChanges();
            }
        }
    }
}
