using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Timesheet.Authorization;
using Timesheet.Timesheet.Projects;
using Timesheet.Timesheet.Timesheets;

namespace Timesheet
{
    [DependsOn(
        typeof(TimesheetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TimesheetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TimesheetAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TimesheetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            //Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            //    cfg => cfg.AddProfiles(thisAssembly)
            //);

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(ProjectMapper.CreateMappings);
            Configuration.Modules.AbpAutoMapper().Configurators.Add(TimesheetMapper.CreateMapping);
        }
    }
}
