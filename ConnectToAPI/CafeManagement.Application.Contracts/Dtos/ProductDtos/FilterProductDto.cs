namespace CafeManagement.Application.Contracts.Dtos.ProductDtos
{
    public class FilterProductDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? Pricemax { get; set; }
        public int? SkipCount { get; set; }
        public int? MaxResultCount { get; set; }
        public int? Choice { get; set; }
    }
}
