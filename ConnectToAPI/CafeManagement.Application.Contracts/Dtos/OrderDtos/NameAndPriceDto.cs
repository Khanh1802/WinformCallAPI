namespace CafeManagement.Application.Contracts.Dtos.OrderDtos
{
    public class NameAndPriceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
