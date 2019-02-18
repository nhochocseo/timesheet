using Abp.Domain.Entities;
using Sieve.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.Entities
{
    public class Member : BaseEntity
    {
        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Address { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Phone { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Email { get; set; }

        public IList<ProjectMember> ProjectMembers { get; set; }
        public IList<TimeSheet> TimeSheets { get; set; }
    }
}
