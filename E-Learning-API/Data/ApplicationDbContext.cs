using E_Learning_API.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace E_Learning_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Lesson>()
                .HasOne(l => l.Course)
                .WithMany(c => c.Lessons)
                .HasForeignKey(l => l.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Reviews)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

           
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Title = "C# Basics", Description = "Learn the basics of C# programming." },
                new Course { CourseId = 2, Title = "ASP.NET Core", Description = "Build web applications with ASP.NET Core." }
            );

            
            modelBuilder.Entity<Lesson>().HasData(
                new Lesson { LessonId = 1, Title = "Introduction to C#", Content = "C# syntax, variables, and data types.", CourseId = 1 },
                new Lesson { LessonId = 2, Title = "Control Flow", Content = "If statements, loops, and switch cases.", CourseId = 1 },
                new Lesson { LessonId = 3, Title = "ASP.NET Core Setup", Content = "Setting up your first ASP.NET Core project.", CourseId = 2 }
            );

            modelBuilder.Entity<Enrollment>().HasData(
    new Enrollment { EnrollmentId = 1, CourseId = 1, EnrolledOn = new DateTime(2025, 1, 15, 10, 0, 0) },
    new Enrollment { EnrollmentId = 2, CourseId = 2, EnrolledOn = new DateTime(2025, 1, 18, 14, 30, 0) }
     );

           
            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewId = 1, CourseId = 1, Rating = 5, Comment = "Great course!" },
                new Review { ReviewId = 2, CourseId = 2, Rating = 4, Comment = "Very informative." }
            );
        }
    }
}
