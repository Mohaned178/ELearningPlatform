using E_Learning_API.Business.Interfaces;
using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.DTOs;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Business.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly ICourseRepository _courseRepository;

        public EnrollmentService(
            IEnrollmentRepository enrollmentRepository,
            ICourseRepository courseRepository)
        {
            _enrollmentRepository = enrollmentRepository;
            _courseRepository = courseRepository;
        }

        public IEnumerable<EnrollmentDto> GetAll()
        {
            return _enrollmentRepository.GetAll()
                .Select(e => new EnrollmentDto
                {
                    EnrollmentId = e.EnrollmentId,
                    CourseId = e.CourseId,
                    CourseTitle = e.Course?.Title
                });
        }

        public EnrollmentDto GetById(int id)
        {
            var e = _enrollmentRepository.GetById(id);
            if (e == null) return null;

            return new EnrollmentDto
            {
                EnrollmentId = e.EnrollmentId,
                CourseId = e.CourseId,
                CourseTitle = e.Course?.Title
            };
        }

        public void Add(EnrollmentDto enrollmentDto)
        {
            var course = _courseRepository.GetById(enrollmentDto.CourseId);
            if (course == null)
                throw new Exception("Course not found");

            var enrollment = new Enrollment
            {
                CourseId = enrollmentDto.CourseId
            };

            _enrollmentRepository.Add(enrollment);
        }

        public void Update(EnrollmentDto enrollmentDto)
        {
            var enrollment = _enrollmentRepository.GetById(enrollmentDto.EnrollmentId);
            if (enrollment == null)
                throw new Exception("Enrollment not found");

            _enrollmentRepository.Update(enrollment);
        }

        public void Delete(int id)
        {
            var enrollment = _enrollmentRepository.GetById(id);
            if (enrollment == null)
                throw new Exception("Enrollment not found");

            _enrollmentRepository.Delete(id);
        }
    }
}
