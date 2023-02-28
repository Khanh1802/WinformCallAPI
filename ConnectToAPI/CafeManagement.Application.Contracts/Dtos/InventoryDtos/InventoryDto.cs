using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using ClassLibrary1.Dtos.ProductDtos;

namespace CafeManagement.Application.Contracts.Dtos.InventoryDtos
{
    public class InventoryDto
    {
        public Guid? Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid WareHouseId { get; set; }
        public ProductDto Product { get; set; }
        public WarehouseDto WareHouse { get; set; }
        public string? ProductName { get; set; }
        public string? WareHouseName { get; set; }
        public int? Quatity { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
