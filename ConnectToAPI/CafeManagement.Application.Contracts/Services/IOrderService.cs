using CafeManagement.Application.Contracts.Dtos.OrderDetailDtos;
using CafeManagement.Application.Contracts.Dtos.OrderDtos;
using CafeManagement.Shared.Helper;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IOrderService
    {
        Task<OrderDto> AddAsync(CreateOrderDto item);
        Task <CommonPageDto<OrderDto>> GetAsync(FilterOrderDetailDto item);
        Task<List<OrderDetailDto>> GetByIdAsync(Guid id);
    }
}
