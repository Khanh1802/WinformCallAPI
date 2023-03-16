using CafeManagement.Application.Contracts.Dtos.OrderDetailDto;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IOrderDetailService
    {
        Task<OrderDetailDto> CreateOrderDetailDtoAsync(CreateOrderDetailDto item);
    }
}
