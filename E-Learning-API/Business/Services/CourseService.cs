using E_Learning_API.Business.Interfaces;
using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.DTOs;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Business.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<CourseDto> GetAll()
        {
            return _courseRepository.GetAll()
                .Select(c => new CourseDto
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Description = c.Description
                });
        }

        public CourseDto GetById(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null) return null;

            return new CourseDto
            {
                CourseId = course.CourseId,
                Title = course.Title,
                Description = course.Description
            };
        }

        public void Add(CourseDto courseDto)
        {
            var course = new Course
            {
                Title = courseDto.Title,
                Description = courseDto.Description
            };

            _courseRepository.Add(course);
        }

        public void Update(CourseDto courseDto)
        {
            var course = _courseRepository.GetById(courseDto.CourseId);
            if (course == null)
                throw new Exception("Course not found");

            course.Title = courseDto.Title;
            course.Description = courseDto.Description;

            _courseRepository.Update(course);
        }

        public void Delete(int id)
        {
            var course = _courseRepository.GetById(id);
            if (course == null)
                throw new Exception("Course not found");

            if (course.Enrollments != null && course.Enrollments.Any())
                throw new Exception("Cannot delete course with active enrollments");

            _courseRepository.Delete(id);
        }
    }
}
