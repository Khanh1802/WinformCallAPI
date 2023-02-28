namespace CafeManagement.Application.Contracts.Dtos.InventoryDtos
{
    public class CreateInventoryDto
    {
        public Guid? ProductId { get; set; }
        public Guid? WareHouseId { get; set; }
        public int Quatity { get; set; }
    }
}
