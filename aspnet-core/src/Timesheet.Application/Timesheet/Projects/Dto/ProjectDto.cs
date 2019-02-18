using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Timesheet.CommonDto;
using Timesheet.Entities;

namespace Timesheet.Timesheet.Projects.Dto
{
    //[AutoMapTo(typeof(Project))]
    public class ProjectDto : BaseProjectDto
    {
        public IEnumerable<ProjectMemberDto> ProjectMembers { get; set; }
        public IEnumerable<ProjectCustomerDto> ProjectCustomers { get; set; }
        public IEnumerable<ProjectTaskDto> ProjectTasks { get; set; }
    }
}
