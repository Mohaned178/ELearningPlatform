using System.ComponentModel.DataAnnotations;

namespace E_Learning_API.Domain.Entities
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }


        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime EnrolledOn { get; set; }
    }
}
