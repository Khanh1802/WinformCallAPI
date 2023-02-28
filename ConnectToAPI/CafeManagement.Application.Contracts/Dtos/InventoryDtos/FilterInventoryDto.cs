namespace CafeManagement.Application.Contracts.Dtos.InventoryDtos
{
    public class FilterInventoryDto
    {
        public Guid? Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? WareHouseId { get; set; }
        public int? Quatity { get; set; }
        public string? ProductName { get; set; }
        public string? WareHouseName { get; set; }
        public int? SkipCount { get; set; }
        public int? TakeMaxResultCount { get; set; }
        public int? Choice { get; set; }
        public string? NameSearch { get; set; }
    }
}
