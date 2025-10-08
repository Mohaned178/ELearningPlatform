using E_Learning_API.Domain.DTOs;
using Microsoft.AspNetCore.Identity;

namespace E_Learning_API.Business.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterAsync(RegisterDto registerDto);
        Task<string> LoginAsync(LoginDto loginDto);
    }
}
