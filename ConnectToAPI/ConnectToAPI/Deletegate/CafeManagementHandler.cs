using CafeManagement.Shared.MemoryCacheKeys;
using Microsoft.Extensions.Caching.Memory;

namespace ConnectToAPI.Deletegate
{
    public class CafeManagementHandler : DelegatingHandler
    {
        private readonly IMemoryCache _memoryCache;

        public CafeManagementHandler(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(!request.Headers.Contains("Authorziation"))
            {
                request.Headers.Add("Authorization", $"Bearer {_memoryCache.Get(UserCache.UserKey)}");
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}
