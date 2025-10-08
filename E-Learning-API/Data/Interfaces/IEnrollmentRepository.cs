using E_Learning_API.Domain.Entities;
using System.Collections.Generic;

namespace E_Learning_API.Data.Interfaces
{
    public interface IEnrollmentRepository
    {
        IEnumerable<Enrollment> GetAll();

        
        IEnumerable<Enrollment> GetByCourseId(int courseId);

        Enrollment GetById(int id);
        void Add(Enrollment enrollment);
        void Update(Enrollment enrollment);
        void Delete(int id);
    }
}
