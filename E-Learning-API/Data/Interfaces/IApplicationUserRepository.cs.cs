using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        Task<ApplicationUser> GetByEmailAsync(string email);
        Task<ApplicationUser> GetByIdAsync(string id);
        Task CreateAsync(ApplicationUser user);
    }
}
