using CafeManagement.Shared.Enums;

namespace CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos
{
    public class CreateInventoryTransactionDto
    {
        public Guid Id { get; set; }
        public Guid InventoryId { get; set; }

        public int Quatity { get; set; }
        public EnumInventoryTransationType Type { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
