using E_Learning_API.Domain.DTOs;

namespace E_Learning_API.Business.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<CourseDto> GetAll();
        CourseDto GetById(int id);
        void Add(CourseDto courseDto);
        void Update(CourseDto courseDto);
        void Delete(int id);
    }
}
