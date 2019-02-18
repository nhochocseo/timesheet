using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Timesheet.Entities;
using Timesheet.Timesheet.Timesheets.Dto;

namespace Timesheet.Timesheet.Timesheets
{
    public static class TimesheetMapper
    {
        public static void CreateMapping(IMapperConfigurationExpression config)
        {
            config.CreateMap<TimeSheet, TimesheetDto>()
                .ReverseMap()
                .ForMember(d => d.TimeSheetItems, options => options.Ignore());
        }
    }
}
