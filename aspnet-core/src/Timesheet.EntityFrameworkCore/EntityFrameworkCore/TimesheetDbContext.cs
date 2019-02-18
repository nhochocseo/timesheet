using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Timesheet.Authorization.Roles;
using Timesheet.Authorization.Users;
using Timesheet.MultiTenancy;
using Timesheet.Entities;

namespace Timesheet.EntityFrameworkCore
{
    public class TimesheetDbContext : AbpZeroDbContext<Tenant, Role, User, TimesheetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCustomer> ProjectCustomers { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<ProjectTask> TaskProjects { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<TimeSheetItem> TimeSheetItems { get; set; }

        public TimesheetDbContext(DbContextOptions<TimesheetDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // project
            modelBuilder.Entity<Project>().HasMany<ProjectCustomer>(g => g.ProjectCustomers);
            modelBuilder.Entity<Project>().HasMany<ProjectMember>(g => g.ProjectMembers);
            modelBuilder.Entity<Project>().HasMany<ProjectTask>(g => g.ProjectTasks);
            // Customer
            modelBuilder.Entity<Customer>().HasMany<ProjectCustomer>(g => g.ProjectCustomers);

            // Member
            modelBuilder.Entity<Member>().HasMany<ProjectMember>(g => g.ProjectMembers);
            modelBuilder.Entity<Member>().HasMany<TimeSheet>(g => g.TimeSheets);

            // TimeSheet
            modelBuilder.Entity<TimeSheet>().HasMany<TimeSheetItem>(g => g.TimeSheetItems);

            //Timesheet Item
            //modelBuilder.Entity<TimeSheetItem>()
            //.HasOne<TimeSheet>(s => s.TimeSheet);
        }
    }
}
