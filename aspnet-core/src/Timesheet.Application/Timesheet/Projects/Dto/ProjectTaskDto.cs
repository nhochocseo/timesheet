using Abp.AutoMapper;
using Abp.Modules;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Timesheet.CommonDto;
using Timesheet.Entities;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.Timesheet.Projects.Dto
{
    public class ProjectTaskDto : BaseProjectTaskDto
    {
        public string Name { get; set; }
        public bool Billable { get; set; }
        public EnumTaskType Type { get; set; }
    }
}
