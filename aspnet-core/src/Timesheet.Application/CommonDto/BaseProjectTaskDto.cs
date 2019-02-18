using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Timesheet.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(ProjectTask))]
    public class BaseProjectTaskDto : BaseEntityDto
    {
        public long TaskId { get; set; }
        public long ProjectId { get; set; }
    }
}
