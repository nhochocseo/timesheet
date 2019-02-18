using Abp.Domain.Entities;
using Sieve.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.Entities
{
    public class TimeSheet: BaseEntity
    {
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime StartDate { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime EndDate { get; set; }

        public IList<TimeSheetItem> TimeSheetItems { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public TimesheetStatus Status { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime ApprovedDate { get; set; }
    }
}
