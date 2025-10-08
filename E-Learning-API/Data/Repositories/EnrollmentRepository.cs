using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E_Learning_API.Data.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

     
        public IEnumerable<Enrollment> GetAll() =>
            _context.Enrollments
                    .Include(e => e.Course)
                    .ToList();

     
        public IEnumerable<Enrollment> GetByCourseId(int courseId) =>
            _context.Enrollments
                    .Include(e => e.Course)
                    .Where(e => e.CourseId == courseId)
                    .ToList();

     
        public Enrollment GetById(int id) =>
            _context.Enrollments
                    .Include(e => e.Course)
                    .FirstOrDefault(e => e.EnrollmentId == id);

      
        public void Add(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();
        }

       
        public void Update(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
        }

        
        public void Delete(int id)
        {
            var enrollment = _context.Enrollments.Find(id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                _context.SaveChanges();
            }
        }
    }
}
