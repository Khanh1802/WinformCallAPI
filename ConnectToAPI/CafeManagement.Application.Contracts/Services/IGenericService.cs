using ClassLibrary1.Dtos.ProductDtos;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IGenericService<TDto, in TCreate, in TKey, in TUpdate,in TFilterDto> where TDto : class
    {
        Task<List<TDto>> GetListAsync(TFilterDto filter);
        Task<TDto> AddAsync(TCreate item);
        Task<bool> DeletedAsync(TKey key);
        Task<TDto> UpdateAsync(TKey key, TUpdate item);
    }
}
