namespace E_Learning_API.Domain.DTOs
{
    public class LessonDto
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public int SequenceNumber { get; set; }
    }
}
