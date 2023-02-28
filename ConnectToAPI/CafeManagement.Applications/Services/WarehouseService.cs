using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using ClassLibrary1.Dtos.Generics;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsWarehouses _options;

        public WarehouseService(HttpClient httpClient, IOptions<OptionsWarehouses> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public Task<WarehouseDto> AddAsync(CreateWarehouseDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletedAsync(Guid key)
        {
            throw new NotImplementedException();
        }

        public async Task<List<WarehouseDto>> GetListAsync(FilterWarehouseDto filter)
            {
            var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetWarehouse}", filter);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<Generic<List<WarehouseDto>>>()).Data;
            }
            else
            {
                return new List<WarehouseDto>();
            }
        }

        public Task<WarehouseDto> UpdateAsync(Guid key, UpdateWarehouseDto item)
        {
            throw new NotImplementedException();
        }
    }
}
