using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.Entities.Enum
{
    public class StatusEnum
    {
        public enum EnumStatus
        {
            Active = 0,
            Deactive = 1
        }
        public enum EnumProjectType
        {
            Timeandmaterials = 0,
            Fixedfee = 1,
            Nonbillable = 2
        }
        public enum EnumTaskType
        {
            Commontask = 0,
            Orthertask = 1
        }
        public enum EnumTypeOfWork
        {
            Normalworkinghours=0,
            Overtime=1
        }
        public enum TimesheetStatus
        {
            None = 0,
            Pedding = 1,
            Approve = 1,
            Reject = 1
        }
    }
}
