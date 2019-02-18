using System;
using System.Collections.Generic;
using System.Text;
using Timesheet.CommonDto;
using Timesheet.Entities;

namespace Timesheet.Timesheet.Timesheets.Dto
{
    public class TimesheetDto: BaseTimeSheetDto
    {
        public IEnumerable<BaseTimeSheetItemDto> TimesheetItems { get; set; }
    }
}
