using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Dtos.InventoryDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Helper;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsInventories _optionsInventories;

        public InventoryService(HttpClient httpClient, IOptions<OptionsInventories> optionsInventories)
        {
            _httpClient = httpClient;
            _optionsInventories = optionsInventories.Value;
        }

        public async Task<InventoryDto> AddAsync(CreateInventoryDto item)
        {
            var create = await _httpClient.PostAsJsonAsync($"{_optionsInventories.CreateInventory}", item);
            var result = await create.Content.ReadFromJsonAsync<GenericResponse<InventoryDto>>();
            try
            {
                create.EnsureSuccessStatusCode();
                return result.Data;
            }
            catch (Exception ex)
            {
                throw new Exception(result.Message);
            }
        }

        public async Task<bool> DeletedAsync(Guid key)
        {
            try
            {
                var delete = await _httpClient.DeleteAsync($"{_optionsInventories.DeleteInventory}/{key}");
                if (delete.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CommonPageDto<InventoryDto>> GetListAsync(FilterInventoryDto filter)
        {
            var getAll = await _httpClient.PostAsJsonAsync($"{_optionsInventories.GetInventory}", filter);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<GenericResponse<CommonPageDto<InventoryDto>>>())?.Data ?? new CommonPageDto<InventoryDto>();
            }
            else
            {
                return new CommonPageDto<InventoryDto>();
            }
        }

        public async Task<InventoryDto> UpdateAsync(Guid key, UpdateInventoryDto item)
        {
            try
            {
                var update = await _httpClient.PutAsJsonAsync($"{_optionsInventories.UpdateInventory}/{key}", item);
                if (update.IsSuccessStatusCode)
                {
                    return (await update.Content.ReadFromJsonAsync<GenericResponse<InventoryDto>>()).Data;
                }
                else
                {
                    throw new Exception($"{update.StatusCode}");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<CommonPageDto<InventoryDto>> GetProductQuantityInventory(FilterInventoryDto filter)
        {
            var getAll = await _httpClient.PostAsJsonAsync($"{_optionsInventories.GetProductQuantityInventory}", filter);
            if (getAll.IsSuccessStatusCode)
            {
                return (await getAll.Content.ReadFromJsonAsync<GenericResponse<CommonPageDto<InventoryDto>>>())?.Data ?? new CommonPageDto<InventoryDto>();
            }
            else
            {
                return new CommonPageDto<InventoryDto>();
            }
        }
    }
}
