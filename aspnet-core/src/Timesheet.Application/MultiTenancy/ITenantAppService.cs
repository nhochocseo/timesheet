using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Timesheet.MultiTenancy.Dto;

namespace Timesheet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

