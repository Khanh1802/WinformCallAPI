﻿using CafeManagement.Shared.Enums;

namespace CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos
{
    public class InventoryTransactionDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string WarehouseName { get; set; }
        public Guid InventoryId { get; set; }
        public int Quatity { get; set; }
        public EnumInventoryTransationType Type { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
