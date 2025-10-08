using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Data.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> GetAll() => _context.Reviews.ToList();

        public IEnumerable<Review> GetByCourseId(int courseId) =>
            _context.Reviews.Where(r => r.CourseId == courseId).ToList();

        public Review GetById(int id) => _context.Reviews.Find(id);

        public void Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void Update(Review review)
        {
            _context.Reviews.Update(review);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                _context.SaveChanges();
            }
        }
    }
}
