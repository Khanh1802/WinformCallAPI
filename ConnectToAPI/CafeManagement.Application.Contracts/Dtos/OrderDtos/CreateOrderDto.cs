using CafeManagement.Application.Contracts.Dtos.CartDto;
using CafeManagement.Shared.Enums;

namespace CafeManagement.Application.Contracts.Dtos.OrderDtos
{
    public class CreateOrderDto
    {
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public EnumDelivery Delivery { get; set; }
        public decimal TotalBill { get; set; }
        public List<CartDetailDto> OrderDetails { get; set; }
    }
}
