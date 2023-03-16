using CafeManagement.Application.Contracts.Dtos.CartDto;

namespace CafeManagement.Application.Contracts.Services
{
    public interface ICartService
    {
        Task<ShoppingCartDto> CreateCartAsync(CreateShoppingDto item);
        Task<ShoppingCartDto> GetCartAsync(string id);
        Task UpdateAsync(UpdateCartDto item);
    }
}
