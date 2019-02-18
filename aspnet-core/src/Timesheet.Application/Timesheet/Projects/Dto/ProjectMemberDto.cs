using Abp.AutoMapper;
using Abp.Modules;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Timesheet.CommonDto;
using Timesheet.Entities;

namespace Timesheet.Timesheet.Projects.Dto
{
    [AutoMapTo(MemberList.Source, typeof(ProjectMember))]
    public class ProjectMemberDto : BaseProjectMemberDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public BaseProjectRoleDto ProjectRole { get; set; }
    }
}
