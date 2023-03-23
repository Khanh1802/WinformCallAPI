using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Shared.Helper;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IInventoryService : IGenericService<InventoryDto, CreateInventoryDto, Guid, UpdateInventoryDto, FilterInventoryDto>
    {
        Task<CommonPageDto<InventoryDto>> GetProductQuantityInventory(FilterInventoryDto filter);
    }
}
