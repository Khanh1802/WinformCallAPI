﻿namespace CafeManagement.Application.Contracts.Dtos.WarehouseDtos
{
    public class WarehouseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
