using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Timesheet.Authorization.Users;
using Timesheet.MultiTenancy;
using Timesheet.IoC;
using Abp.ObjectMapping;
using Abp.Dependency;

namespace Timesheet
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AppServiceBase : ApplicationService
    {
        protected TenantManager TenantManager { get; set; }

        protected UserManager UserManager { get; set; }

        protected IWorkScope WorkScope { get; set; }

        protected AppServiceBase()
        {
            LocalizationSourceName = TimesheetConsts.LocalizationSourceName;
            WorkScope = IocManager.Instance.Resolve<IWorkScope>();
            ObjectMapper = IocManager.Instance.Resolve<IObjectMapper>();
            UserManager = IocManager.Instance.Resolve<UserManager>();
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
