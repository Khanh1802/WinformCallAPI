using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.InventoryTransactionDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Helper;
using CafeManagement.Shared.Options;
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
                return (await create.Content.ReadFromJsonAsync<GenericResponse<InventoryTransactionDto>>()).Data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CommonPageDto<InventoryTransactionDto>> GetListAsync(FilterInventoryTransactionDto item)
        {
            var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetInventoryHistory}", item);
            var result = await getAll.Content.ReadFromJsonAsync<GenericResponse<CommonPageDto<InventoryTransactionDto>>>();
            try
            {
                getAll.EnsureSuccessStatusCode();
                return result.Data;
            }
            catch
            {
                throw new Exception(result.Message);
            }
        }
    }
}
