using E_Learning_API.Domain.DTOs;

namespace E_Learning_API.Business.Interfaces
{
    public interface IEnrollmentService
    {
        IEnumerable<EnrollmentDto> GetAll();
        EnrollmentDto GetById(int id);
        void Add(EnrollmentDto enrollmentDto);
        void Update(EnrollmentDto enrollmentDto);
        void Delete(int id);
    }
}
