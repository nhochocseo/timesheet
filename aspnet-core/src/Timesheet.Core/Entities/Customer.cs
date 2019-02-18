using Abp.Domain.Entities;
using Sieve.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using static Timesheet.Entities.Enum.StatusEnum;

namespace Timesheet.Entities
{
    public class Customer : BaseEntity
    {
        [Sieve(CanFilter = true, CanSort = true)]
        public string Name { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Address { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Phone { get; set; }
        [Sieve(CanFilter = true, CanSort = true)]
        public string Email { get; set; }

        public IList<ProjectCustomer> ProjectCustomers { get; set; }
    }
}
