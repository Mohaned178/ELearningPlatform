using Microsoft.AspNetCore.Identity;
using E_Learning_API.Data.Interfaces;
using E_Learning_API.Domain.Entities;

namespace E_Learning_API.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<ApplicationUser> GetByIdAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task CreateAsync(ApplicationUser user)
        {
            await _userManager.CreateAsync(user);
        }
    }
}
