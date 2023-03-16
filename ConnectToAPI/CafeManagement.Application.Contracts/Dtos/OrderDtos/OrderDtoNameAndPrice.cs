namespace CafeManagement.Application.Contracts.Dtos.OrderDtos
{
    public class OrderDtoNameAndPrice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  decimal Price { get; set; }
    }
}
