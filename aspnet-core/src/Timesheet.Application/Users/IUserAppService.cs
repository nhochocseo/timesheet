using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Timesheet.Roles.Dto;
using Timesheet.Users.Dto;

namespace Timesheet.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
