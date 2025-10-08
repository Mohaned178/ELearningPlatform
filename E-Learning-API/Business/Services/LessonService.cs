using E_Learning_API.Business.Interfaces;
using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.DTOs;
using E_Learning_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Learning_API.Business.Services
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        private readonly ICourseRepository _courseRepository;

        public LessonService(ILessonRepository lessonRepository, ICourseRepository courseRepository)
        {
            _lessonRepository = lessonRepository;
            _courseRepository = courseRepository;
        }

        public IEnumerable<LessonDto> GetAll()
        {
            return _lessonRepository.GetAll()
                .Select(l => new LessonDto
                {
                    LessonId = l.LessonId,
                    Title = l.Title,
                    Content = l.Content,
                    CourseId = l.CourseId,
                    CourseTitle = l.Course?.Title
                });
        }

        public IEnumerable<LessonDto> GetByCourseId(int courseId)
        {
            return _lessonRepository.GetAll()
                .Where(l => l.CourseId == courseId)
                .Select(l => new LessonDto
                {
                    LessonId = l.LessonId,
                    Title = l.Title,
                    Content = l.Content,
                    CourseId = l.CourseId,
                    CourseTitle = l.Course?.Title
                });
        }

        public LessonDto GetById(int id)
        {
            var l = _lessonRepository.GetById(id);
            if (l == null) return null;

            return new LessonDto
            {
                LessonId = l.LessonId,
                Title = l.Title,
                Content = l.Content,
                CourseId = l.CourseId,
                CourseTitle = l.Course?.Title
            };
        }

        public void Add(LessonDto lessonDto)
        {
            var course = _courseRepository.GetById(lessonDto.CourseId);
            if (course == null)
                throw new Exception("Course not found");

            var lesson = new Lesson
            {
                Title = lessonDto.Title,
                Content = lessonDto.Content,
                CourseId = lessonDto.CourseId
            };

            _lessonRepository.Add(lesson);
        }

        public void Update(LessonDto lessonDto)
        {
            var lesson = _lessonRepository.GetById(lessonDto.LessonId);
            if (lesson == null)
                throw new Exception("Lesson not found");

            lesson.Title = lessonDto.Title;
            lesson.Content = lessonDto.Content;

            _lessonRepository.Update(lesson);
        }

        public void Delete(int id)
        {
            var lesson = _lessonRepository.GetById(id);
            if (lesson == null)
                throw new Exception("Lesson not found");

            _lessonRepository.Delete(id);
        }
    }
}
