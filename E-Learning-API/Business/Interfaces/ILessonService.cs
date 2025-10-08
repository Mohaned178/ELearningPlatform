using E_Learning_API.Domain.DTOs;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Business.Interfaces
{
    public interface ILessonService
    {
        IEnumerable<LessonDto> GetAll();
        IEnumerable<LessonDto> GetByCourseId(int courseId);
        LessonDto GetById(int id);
        void Add(LessonDto lessonDto);
        void Update(LessonDto lessonDto);
        void Delete(int id);

    }
}
