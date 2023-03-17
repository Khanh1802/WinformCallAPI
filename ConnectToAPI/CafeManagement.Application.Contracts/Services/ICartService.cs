using CafeManagement.Application.Contracts.Dtos.CartDto;

namespace CafeManagement.Application.Contracts.Services
{
    public interface ICartService
    {
        Task<CartDto> CreateCartAsync(CreateCartDto item);
        Task<CartDto> GetCartAsync(string id);
        Task UpdateAsync(UpdateCartDto item);
    }
}
