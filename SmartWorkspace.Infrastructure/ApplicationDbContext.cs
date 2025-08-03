using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWorkspace.Domain.Entities.Identity;

namespace SmartWorkspace.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

   /* public DbSet<Project> Projects { get; set; }
    public DbSet<TaskItem> Tasks { get; set; }
    public DbSet<TaskComment> TaskComments { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }*/
}
