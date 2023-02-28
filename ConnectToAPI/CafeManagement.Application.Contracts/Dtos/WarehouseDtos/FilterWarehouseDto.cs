namespace CafeManagement.Application.Contracts.Dtos.WarehouseDtos
{
    public class FilterWarehouseDto 
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? SkipCount { get; set; }
        public int? TakeMaxResultCount { get; set; }
    }
}
