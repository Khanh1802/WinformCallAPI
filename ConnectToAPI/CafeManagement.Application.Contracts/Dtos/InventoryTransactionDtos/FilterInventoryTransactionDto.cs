using CafeManagement.Shared.Enums;

namespace CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos
{
    public class FilterInventoryTransactionDto
    {
        public Guid? Id { get; set; }
        public int Type { get; set; }
        public Guid? WarehouseId { get; set; }
        public Guid? ProductId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? SkipCount { get; set; }
        public int? MaxResultCount { get; set; }
        public int Choice { get; set; }
        public string? NameSearch { get; set; }
    }
}
