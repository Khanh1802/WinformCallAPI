using CafeManagement.Application.Contracts.Dtos.WarehouseDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Helper;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.ProductDtos;

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

        public async Task<CommonPageDto<WarehouseDto>> GetListAsync(FilterWarehouseDto filter)
            {
            var getAll = await _httpClient.PostAsJsonAsync($"{_options.GetWarehouse}", filter);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<GenericResponse<CommonPageDto<WarehouseDto>>>())?.Data ?? new CommonPageDto<WarehouseDto>();
            }
            else
            {
                return new CommonPageDto<WarehouseDto>();
            }
        }

        public Task<WarehouseDto> UpdateAsync(Guid key, UpdateWarehouseDto item)
        {
            throw new NotImplementedException();
        }
    }
}
