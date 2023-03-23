using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;
using CafeManagement.Shared.Helper;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IInventoryTransactionService
    {
        Task<InventoryTransactionDto> AddAsync(CreateInventoryTransactionDto item);
        Task<CommonPageDto<InventoryTransactionDto>> GetListAsync(FilterInventoryTransactionDto item);
    }
}
