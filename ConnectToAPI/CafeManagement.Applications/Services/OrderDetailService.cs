using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using CafeManagement.Application.Contracts.Dtos.OrderDetailDtos;

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
        
    }
}
