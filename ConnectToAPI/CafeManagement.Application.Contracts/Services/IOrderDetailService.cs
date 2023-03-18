using CafeManagement.Application.Contracts.Dtos.OrderDetailDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IOrderDetailService
    {
        Task<OrderDetailDto> CreateOrderDetailDtoAsync(CreateOrderDetailDto item);
    }
}
