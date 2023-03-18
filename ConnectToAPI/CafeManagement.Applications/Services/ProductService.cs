using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Helper;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;

namespace CafeManagement.Applications.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsProductst _options;

        public ProductService(HttpClient httpClient, IOptions<OptionsProductst> productOptions)
        {
            _httpClient = httpClient;
            _options = productOptions.Value;
        }

        public async Task<ProductDto> AddAsync(CreateProductDto item)
        {
            try
            {
                var create = await _httpClient.PostAsJsonAsync($"{_options.CreateProduct}", item);
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
            try
            {
                var delete = await _httpClient.DeleteAsync($"{_options.DeleteProduct}/{key}");
                delete.EnsureSuccessStatusCode();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<CommonPageDto<ProductDto>> GetListAsync(FilterProductDto filterProduct)
        {
            var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetProduct}",filterProduct);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<Generic<CommonPageDto<ProductDto>>>())?.Data ?? new CommonPageDto<ProductDto>();
            }
            else
            {
                return new CommonPageDto<ProductDto>();
            }
        }

        public async Task<ProductDto> UpdateAsync(Guid key, UpdateProductDto item)
        {
            try
            {
                var update = await _httpClient.PutAsJsonAsync($"{_options.UpdateProduct}/{key}", item);
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
