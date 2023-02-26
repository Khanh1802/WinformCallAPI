using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using ClassLibrary1.Dtos.Generics;
using ClassLibrary1.Dtos.ProductDtos;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsCafeManagement _options;

        public ProductService(HttpClient httpClient, IOptions<OptionsCafeManagement> productOptions)
        {
            _httpClient = httpClient;
            _options = productOptions.Value;
        }

        public async Task<ProductDto> AddAsync(CreateProductDto item)
        {
            var create = await _httpClient.PostAsJsonAsync($"{_options.PostProduct}", item);
            try
            {
                create.EnsureSuccessStatusCode();
                var productDto = (await create.Content.ReadFromJsonAsync<Generic<ProductDto>>()).Data;
                return productDto;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeletedAsync(Guid key)
        {
            var delete = await _httpClient.DeleteAsync($"{_options.DeleteProduct}/{key}");
            try
            {
                delete.EnsureSuccessStatusCode();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<ProductDto>> GetListAsync(FilterProductDto filterProduct)
        {
            var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetProduct}",filterProduct);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<Generic<List<ProductDto>>>())?.Data ?? new List<ProductDto>();
            }
            else
            {
                return new List<ProductDto>();
            }
        }

        public async Task<ProductDto> UpdateAsync(Guid key, UpdateProductDto item)
        {
            var update = await _httpClient.PutAsJsonAsync($"{_options.PutProduct}/{key}",item);
            try
            {
                update.EnsureSuccessStatusCode();
                return (await update.Content.ReadFromJsonAsync<Generic<ProductDto>>()).Data;
            }
            catch
            {
                return null;
            }
        }
    }
}
