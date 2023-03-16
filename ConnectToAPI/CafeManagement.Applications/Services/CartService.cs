using CafeManagement.Application.Contracts.Dtos.CartDto;
using CafeManagement.Application.Contracts.Dtos.Generics;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace CafeManagement.Applications.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;
        private readonly OptionsCart _optionsCart;

        public CartService(IOptions<OptionsCart> optionsCart, HttpClient httpClient)
        {
            _optionsCart = optionsCart.Value;
            _httpClient = httpClient;
        }

        public async Task<ShoppingCartDto> CreateCartAsync(CreateShoppingDto item)
        {
            try
            {
                var create = await _httpClient.PostAsJsonAsync($"{_optionsCart.CreateCart}", item);
                create.EnsureSuccessStatusCode();
                var cartDto = (await create.Content.ReadFromJsonAsync<ShoppingCartDto>());
                return cartDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ShoppingCartDto> GetCartAsync(string id)
        {
            // _option.GetCart => GetCart ở đây là dựa vào string appsetting.json va class option
            try
            {
                var getCart = await _httpClient.GetAsync($"{_optionsCart.GetCart}/{id}");
                getCart.EnsureSuccessStatusCode();
                var cartDto = (await getCart.Content.ReadFromJsonAsync<Generic<ShoppingCartDto>>()).Data ?? new ShoppingCartDto();
                return cartDto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(UpdateCartDto item)
        {
            try
            {
                var deleteCart = await _httpClient.PutAsJsonAsync($"{_optionsCart.UpdateCart}",item);
                deleteCart.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
