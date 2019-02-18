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
    [AutoMapTo(typeof(Customer))]
    public class BaseCustomerDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
