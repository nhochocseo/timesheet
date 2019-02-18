using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timesheet.CommonDto;
using Timesheet.Entities;
using Timesheet.Timesheet.Projects.Dto;

namespace Timesheet.Timesheet.Projects
{
    public class ProjectService : AppServiceFilterBase<Project, ProjectDto>
    {
        public override async Task<ProjectDto> Save(ProjectDto req)
        {
                var result = await base.SaveReturnEntity(req);
                // save project member
                await WorkScope.Sync<BaseProjectMemberDto, ProjectMember>(req.ProjectMembers, x => x.ProjectId == result.Id, x => {
                    x.ProjectId = result.Id;
                    return x;
                });
                // save project customer
                await WorkScope.Sync<BaseProjectCustomerDto, ProjectCustomer>(req.ProjectCustomers, x => x.ProjectId == result.Id, x => {
                    x.ProjectId = result.Id;
                    return x;
                });
                // save project task
                await WorkScope.Sync<BaseProjectTaskDto, Entities.ProjectTask>(req.ProjectTasks, x => x.ProjectId == result.Id, x =>
                {
                    x.ProjectId = result.Id;
                    return x;
                });
                var rs = ObjectMapper.Map<ProjectDto>(result);
                return rs;
        }
    }
}
