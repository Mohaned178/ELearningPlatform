using E_Learning_API.Business.Interfaces;
using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.DTOs;
using E_Learning_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Learning_API.Business.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly ICourseRepository _courseRepository;

        public ReviewService(
            IReviewRepository reviewRepository,
            ICourseRepository courseRepository)
        {
            _reviewRepository = reviewRepository;
            _courseRepository = courseRepository;
        }

        public IEnumerable<ReviewDto> GetAll()
        {
            return _reviewRepository.GetAll()
                .Select(r => new ReviewDto
                {
                    ReviewId = r.ReviewId,
                    CourseId = r.CourseId,
                    CourseTitle = r.Course?.Title,
                    Rating = r.Rating,
                    Comment = r.Comment
                });
        }

        public IEnumerable<ReviewDto> GetByCourseId(int courseId)
        {
            return _reviewRepository.GetAll()
                .Where(r => r.CourseId == courseId)
                .Select(r => new ReviewDto
                {
                    ReviewId = r.ReviewId,
                    CourseId = r.CourseId,
                    CourseTitle = r.Course?.Title,
                    Rating = r.Rating,
                    Comment = r.Comment
                });
        }

        public ReviewDto GetById(int id)
        {
            var r = _reviewRepository.GetById(id);
            if (r == null) return null;

            return new ReviewDto
            {
                ReviewId = r.ReviewId,
                CourseId = r.CourseId,
                CourseTitle = r.Course?.Title,
                Rating = r.Rating,
                Comment = r.Comment
            };
        }

        public void Add(ReviewDto reviewDto)
        {
            
            var course = _courseRepository.GetById(reviewDto.CourseId);
            if (course == null)
                throw new Exception("Course not found");

            var review = new Review
            {
                CourseId = reviewDto.CourseId,
                Rating = reviewDto.Rating,
                Comment = reviewDto.Comment
            };

            _reviewRepository.Add(review);
        }

        public void Update(ReviewDto reviewDto)
        {
            var review = _reviewRepository.GetById(reviewDto.ReviewId);
            if (review == null)
                throw new Exception("Review not found");

            review.Rating = reviewDto.Rating;
            review.Comment = reviewDto.Comment;

            _reviewRepository.Update(review);
        }

        public void Delete(int id)
        {
            var review = _reviewRepository.GetById(id);
            if (review == null)
                throw new Exception("Review not found");

            _reviewRepository.Delete(id);
        }
    }
}
