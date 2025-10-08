E-Learning Platform API
A robust RESTful API for an online learning management system built with .NET 8. This backend service enables instructors to create and manage courses while providing students with access to course materials, lessons, and interactive features.
Features
Authentication & Authorization

User registration and login with JWT authentication
Role-based access control (Student, Instructor, Admin)
Secure password hashing
Token-based authentication

Course Management

Create, read, update, and delete courses
Browse and search available courses
Course categorization and filtering

Lesson Management

Add lessons to courses
Organize course content
Lesson progress tracking

Enrollment System

Student course enrollment
Enrollment status tracking
Enrollment history

Review System

Course reviews and ratings
Student feedback collection 

Tech Stack
Backend

.NET 8 - Web API framework
C# - Programming language
SQL Server - Relational database
Entity Framework Core - ORM for database operations
JWT (JSON Web Tokens) - Authentication and authorization
ASP.NET Core Identity - User management

Architecture

Clean Architecture - Separation of concerns
Repository Pattern - Data access abstraction
Service Layer - Business logic encapsulation
Dependency Injection - Loose coupling and testability

Project Architecture
ELearningPlatform/
├── 📂 Presentation/
│   └── Controllers/
│       ├── AccountController.cs      // Login, Register
│       ├── CourseController.cs       // Course CRUD operations
│       ├── EnrollmentController.cs   // Enrollment management
│       ├── ReviewController.cs       // Course reviews
│       └── LessonController.cs       // Lesson management
│
├── 📂 Business/
│   ├── Interfaces/
│   │   ├── IAccountService.cs
│   │   ├── ICourseService.cs
│   │   ├── IEnrollmentService.cs
│   │   ├── IReviewService.cs
│   │   └── ILessonService.cs
│   │
│   └── Services/
│       ├── AccountService.cs         // Authentication logic
│       ├── CourseService.cs          // Course business logic
│       ├── EnrollmentService.cs      // Enrollment logic
│       ├── ReviewService.cs          // Review management
│       └── LessonService.cs          // Lesson operations
│
├── 📂 Data/
│   ├── Interfaces/
│   │   ├── IApplicationUserRepository.cs
│   │   ├── ICourseRepository.cs
│   │   ├── IEnrollmentRepository.cs
│   │   ├── IReviewRepository.cs
│   │   └── ILessonRepository.cs
│   │
│   ├── Repositories/
│   │   ├── ApplicationUserRepository.cs
│   │   ├── CourseRepository.cs
│   │   ├── EnrollmentRepository.cs
│   │   ├── ReviewRepository.cs
│   │   └── LessonRepository.cs
│   │
│   ├── ApplicationDbContext.cs       // EF Core DbContext
│   └── 📂 Migrations/                // Database migrations
│
└── 📂 Domain/
    ├── Entities/
    │   ├── ApplicationUser.cs        // User entity
    │   ├── Course.cs                 // Course entity
    │   ├── Lesson.cs                 // Lesson entity
    │   ├── Enrollment.cs             // Enrollment entity
    │   └── Review.cs                 // Review entity
    │
    └── DTOs/
        ├── LoginDTO.cs
        ├── RegisterDTO.cs
        ├── CourseDto.cs
        ├── LessonDto.cs
        ├── EnrollmentDto.cs
        └── ReviewDto.cs
