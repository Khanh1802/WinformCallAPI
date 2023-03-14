namespace CafeManagement.Application.Contracts.Dtos.OrderDetailDto
{
    public class CreateOrderDetailDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public int STT { get; set; }
    }
}
