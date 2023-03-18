using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.OrderDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsOrder _optionsOrder;

        public OrderService(IOptions<OptionsOrder> optionsOrder, HttpClient httpClient)
        {
            _optionsOrder = optionsOrder.Value;
            _httpClient = httpClient;
        }

        public async Task<OrderDto> AddAsync(CreateOrderDto item)
        {
            try
            {
                if (item.OrderDetails.Count == 0)
                {
                    throw new Exception("Cart is empty");
                }
                var create = await _httpClient.PostAsJsonAsync($"{_optionsOrder.CreateOrder}", item);
                create.EnsureSuccessStatusCode();
                return (await create.Content.ReadFromJsonAsync<Generic<OrderDto>>()).Data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            try
            {
                await _httpClient.DeleteAsync($"{_optionsOrder.DeleteOrder}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
