using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using ClassLibrary1.Dtos.Generics;
using ClassLibrary1.Dtos.UserDtos;
using ClassLibrary1.MemoryCacheKeys;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsLogins _options;
        private readonly IMemoryCache _memoryCache;

        public UserService(HttpClient httpClient, IOptions<OptionsLogins> options, IMemoryCache memoryCache)
        {
            _httpClient = httpClient;
            _options = options.Value;
            _memoryCache = memoryCache;
        }

        public async Task<bool> LoginAsync(LoginUser loginUser)
        {           
            var getToken = await _httpClient.PostAsJsonAsync($"{_options.Login}", loginUser);
            try
            {
                getToken.EnsureSuccessStatusCode();
                var token = (await getToken.Content.ReadFromJsonAsync<Generic<string>>())?.Data;
                if(!string.IsNullOrEmpty(token))
                {
                    _memoryCache.Set(UserCache.UserKey, token);
                    return true;
                }              
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
