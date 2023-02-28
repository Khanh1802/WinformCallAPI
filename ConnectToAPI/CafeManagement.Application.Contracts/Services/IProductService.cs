using ClassLibrary1.Dtos.ProductDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IProductService : IGenericService<ProductDto, CreateProductDto, Guid, UpdateProductDto, FilterProductDto>
    {

    }
}
