using System.ComponentModel.DataAnnotations;

namespace E_Learning_API.Domain.Entities
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        

        public int CourseId { get; set; }
        public Course Course { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
