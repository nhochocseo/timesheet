﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.Entities
{
    public class ProjectTask : BaseEntity
    {
        public Task Task { get; set; }
        public long TaskId { get; set; }

        public Project Project { get; set; }
        public long ProjectId { get; set; }
    }
}
