using CafeManagement.Application.Contracts.Dtos.UserTypeDtos;
using CafeManagement.Shared.Helper;

namespace CafeManagement.Application.Contracts.Services
{
    public interface IUserTypeService
    {
        Task<CommonPageDto<UserTypeDto>> GetPagedListAsync(FilterUserTypeDto item);
    }
}
