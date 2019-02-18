using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Timesheet.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(TimeSheetItem))]
    public class BaseTimeSheetItemDto : BaseEntityDto
    {
        public long WorkingTime { get; set; }//min
        public long UserID { get; set; }
        public long ProjectID { get; set; }
        public long TaskID { get; set; }
        public EnumTypeOfWork TypeOfWork { get; set; }
        public bool IsChange { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Note { get; set; }

        public BaseMemberDto Member { get; set; }
        public BaseProjectDto Project { get; set; }
        public BaseTaskDto Task { get; set; }
    }
}
