using Microsoft.AspNetCore.Identity;

namespace E_Learning_API.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
