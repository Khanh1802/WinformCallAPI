using CafeManagement.Application.Contracts.Dtos.UserDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IUserService
    {
        Task<bool> LoginAsync(LoginUser loginUser); 
    }
}
