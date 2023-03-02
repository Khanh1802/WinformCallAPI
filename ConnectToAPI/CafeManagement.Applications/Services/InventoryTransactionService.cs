using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using ClassLibrary1.Dtos.Generics;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class InventoryTransactionService : IInventoryTransactionService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsInventoryTransactions _options;

        public InventoryTransactionService(HttpClient httpClient,
            IOptions<OptionsInventoryTransactions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<InventoryTransactionDto> AddAsync(CreateInventoryTransactionDto item)
        {
            try
            {
                var create = await _httpClient.PostAsJsonAsync($"{_options.CreateInventoryStatistics}", item);
                if (!create.IsSuccessStatusCode)
                {
                    return null;
                }
                return (await create.Content.ReadFromJsonAsync<Generic<InventoryTransactionDto>>()).Data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<InventoryTransactionDto>> GetListAsync(FilterInventoryTransactionDto item)
        {
            try
            {
                var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetInventoryStatistics}", item);
                if (getAll.IsSuccessStatusCode)
                {
                    return (await getAll.Content.ReadFromJsonAsync<Generic<List<InventoryTransactionDto>>>()).Data;
                }
                return new List<InventoryTransactionDto>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
