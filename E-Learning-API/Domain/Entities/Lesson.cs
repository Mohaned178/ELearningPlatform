using System.ComponentModel.DataAnnotations;

namespace E_Learning_API.Domain.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        [Required, MaxLength(200)]
        public string Title { get; set; }

        public string Content { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
