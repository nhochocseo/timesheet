using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.Entities
{
    public class TimeSheetItem : BaseEntity
    {
        public long WorkingTime { get; set; }//min
        public long MemberId { get; set; }
        public long ProjectId { get; set; }
        public long TimesheetId { get; set; }
        public long TaskId { get; set; }
        public EnumTypeOfWork TypeOfWork { get; set; }
        public bool IsChange { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Note { get; set; }
        public Member Member { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }
        public TimeSheet TimeSheet { get; set; }
    }
}
