using Abp.Domain.Entities;
using Timesheet.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;
using Sieve.Attributes;
using AutoMapper;
using Abp.AutoMapper;

namespace Timesheet.Entities
{
    public class Project : BaseEntity
    {
        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime TimeStart { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime TimeEnd { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public EnumStatus Status { get; set; }
        public string Code { get; set; }
        public EnumProjectType ProjectType { get; set; }
        public string Note { get; set; }

        public IList<ProjectMember> ProjectMembers { get; set; }
        public IList<ProjectCustomer> ProjectCustomers { get; set; }
        public IList<ProjectTask> ProjectTasks { get; set; }
    }
}
