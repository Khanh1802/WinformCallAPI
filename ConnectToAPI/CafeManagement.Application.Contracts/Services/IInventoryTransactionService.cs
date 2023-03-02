using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IInventoryTransactionService
    {
        Task<InventoryTransactionDto> AddAsync(CreateInventoryTransactionDto item);
        Task<List<InventoryTransactionDto>> GetListAsync(FilterInventoryTransactionDto item);
    }
}
