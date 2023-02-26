namespace ClassLibrary1.Dtos.ProductDtos
{
    public class FilterProductDto
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? Pricemax { get; set; }
        public int? SkipCount { get; set; }
        public int? TakeMaxResultCount { get; set; }
        public int? Choice { get; set; }
    }
}
