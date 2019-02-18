using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Sieve.Services;
using Timesheet.Authorization;
using Timesheet.Authorization.Roles;
using Timesheet.Authorization.Users;
using Timesheet.Editions;
using Timesheet.MultiTenancy;

namespace Timesheet.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            services.AddScoped<ISieveProcessor, SieveProcessor>();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
