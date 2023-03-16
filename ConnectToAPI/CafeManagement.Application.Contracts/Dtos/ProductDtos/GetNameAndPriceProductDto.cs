namespace CafeManagement.Application.Contracts.Dtos.ProductDtos
{
    public class GetNameAndPriceProductDto
    {
        public Guid ProductId { get; set; }
        public string NameAndPrice { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
