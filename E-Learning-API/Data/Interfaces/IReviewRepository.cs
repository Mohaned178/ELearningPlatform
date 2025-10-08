using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Data.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        IEnumerable<Review> GetByCourseId(int courseId);
        Review GetById(int id);
        void Add(Review review);
        void Update(Review review);
        void Delete(int id);
    }
}
