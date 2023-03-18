using CafeManagement.Application.Contracts.Dtos.OrderDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IOrderService
    {
        Task<OrderDto> AddAsync(CreateOrderDto item);
        Task DeleteAsync(Guid id);
    }
}
