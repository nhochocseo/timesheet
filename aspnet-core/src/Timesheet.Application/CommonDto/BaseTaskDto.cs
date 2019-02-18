﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Timesheet.Entities;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(Task))]
    public class BaseTaskDto : BaseEntityDto
    {
        public string Name { get; set; }
        public bool Billable { get; set; }
        public EnumTaskType Type { get; set; }
    }
}
