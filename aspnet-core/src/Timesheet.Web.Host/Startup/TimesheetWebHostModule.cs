﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Timesheet.Configuration;

namespace Timesheet.Web.Host.Startup
{
    [DependsOn(
       typeof(TimesheetWebCoreModule))]
    public class TimesheetWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TimesheetWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimesheetWebHostModule).GetAssembly());
        }
    }
}
