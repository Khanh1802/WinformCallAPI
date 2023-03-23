namespace CafeManagement.Application.Contracts.Dtos.OrderDtos
{
    public class FilterOrderDetailDto
    {
        public Guid? Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int MaxResultCount { get; set; }
        public int SkipCount { get; set; }
    }
}
