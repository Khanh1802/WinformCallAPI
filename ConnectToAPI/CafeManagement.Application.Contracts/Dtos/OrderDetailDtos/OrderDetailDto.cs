﻿namespace CafeManagement.Application.Contracts.Dtos.OrderDetailDtos
{
    public class OrderDetailDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
