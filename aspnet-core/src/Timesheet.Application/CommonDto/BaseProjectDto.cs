using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Timesheet.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(Project))]
    public class BaseProjectDto : BaseEntityDto
    {
        public string Name { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public EnumStatus Status { get; set; }
        public string Code { get; set; }
        public EnumProjectType ProjectType { get; set; }
        public string Note { get; set; }
    }
}
