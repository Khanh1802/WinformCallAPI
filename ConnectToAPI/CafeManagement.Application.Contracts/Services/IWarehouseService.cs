using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IWarehouseService : IGenericService<WarehouseDto, CreateWarehouseDto, Guid, UpdateWarehouseDto,FilterWarehouseDto>
    {
    }
}
