using System.ComponentModel.DataAnnotations;

namespace E_Learning_API.Domain.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required, MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}

