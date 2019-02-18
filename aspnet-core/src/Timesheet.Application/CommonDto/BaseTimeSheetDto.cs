using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Timesheet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(TimeSheet))]
    public class BaseTimeSheetDto : BaseEntityDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimesheetStatus Status { get; set; }
        public DateTime ApprovedDate { get; set; }
    }
}
