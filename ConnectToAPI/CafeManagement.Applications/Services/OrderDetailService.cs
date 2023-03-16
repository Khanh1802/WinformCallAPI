using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Application.Contracts.Dtos.OrderDetailDto;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsCart _options;

        public OrderDetailService(HttpClient httpClient, IOptions<OptionsCart> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<OrderDetailDto> CreateOrderDetailDtoAsync(CreateOrderDetailDto item)
        {
            try
            {
                var create = await _httpClient.PostAsJsonAsync($"{_options.CreateCart}", item);
                create.EnsureSuccessStatusCode();
                return (await create.Content.ReadFromJsonAsync<Generic<OrderDetailDto>>()).Data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
