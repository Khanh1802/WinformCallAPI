using CafeManagement.Application.Contracts.Dtos.UserTypeDtos;
using CafeManagement.Application.Contracts.Services;
using CafeManagement.Shared.Helper;

namespace CafeManagement.Applications.Services
{
    public class UserTypeService : IUserTypeService
    {
        public Task<CommonPageDto<UserTypeDto>> GetPagedListAsync(FilterUserTypeDto item)
        {
            throw new NotImplementedException();
        }
    }
}
