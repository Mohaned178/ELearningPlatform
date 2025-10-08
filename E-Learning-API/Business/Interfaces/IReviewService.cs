using E_Learning_API.Domain.DTOs;

namespace E_Learning_API.Business.Interfaces
{
    public interface IReviewService
    {
        IEnumerable<ReviewDto> GetAll();
        IEnumerable<ReviewDto> GetByCourseId(int courseId);
        ReviewDto GetById(int id);
        void Add(ReviewDto reviewDto);
        void Update(ReviewDto reviewDto);
        void Delete(int id);
    }
}
