using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Timesheet.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.CommonDto
{
    [AutoMapTo(typeof(ProjectMember))]
    public class BaseProjectMemberDto : BaseEntityDto
    {
        public long MemberId { get; set; }
        public long ProjectId { get; set; }
        public long? ProjectRoleId { get; set; }
    }
}
