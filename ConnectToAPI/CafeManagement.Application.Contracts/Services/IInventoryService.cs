using CafeManagement.Application.Contracts.Dtos.InventoryDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IInventoryService : IGenericService<InventoryDto, CreateInventoryDto, Guid, UpdateInventoryDto, FilterInventoryDto>
    {
    }
}
