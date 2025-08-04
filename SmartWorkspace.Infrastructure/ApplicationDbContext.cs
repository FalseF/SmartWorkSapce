using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartWorkspace.Domain.Entities.Identity;
using SmartWorkspace.Domain.Entities.Project;

namespace SmartWorkspace.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,string>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Add all domain entities
    public DbSet<Project> Projects { get; set; }
    /* public DbSet<TaskItem> Tasks { get; set; }
     public DbSet<TaskComment> TaskComments { get; set; }
     public DbSet<Notification> Notifications { get; set; }
     public DbSet<ActivityLog> ActivityLogs { get; set; }
     public DbSet<Permission> Permissions { get; set; }
     public DbSet<RolePermission> RolePermissions { get; set; }
     public DbSet<UserRole> UserRoles { get; set; }*/

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserRole>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);

        builder.Entity<UserRole>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleId);

      /*  // RolePermission (many-to-many join table)
        builder.Entity<RolePermission>()
            .HasKey(rp => new { rp.RoleId, rp.PermissionId });

        builder.Entity<RolePermission>()
            .HasOne(rp => rp.Role)
            .WithMany(r => r.RolePermissions)
            .HasForeignKey(rp => rp.RoleId);

        builder.Entity<RolePermission>()
            .HasOne(rp => rp.Permission)
            .WithMany()
            .HasForeignKey(rp => rp.PermissionId);

        // TaskItem → Project (many-to-one)
        builder.Entity<TaskItem>()
            .HasOne(t => t.Project)
            .WithMany(p => p.Tasks)
            .HasForeignKey(t => t.ProjectId);

        // TaskItem → AppUser (assigned to)
        builder.Entity<TaskItem>()
            .HasOne(t => t.AssignedTo)
            .WithMany()
            .HasForeignKey(t => t.AssignedToId);

        // TaskComment → TaskItem (many-to-one)
        builder.Entity<TaskComment>()
            .HasOne(c => c.TaskItem)
            .WithMany(t => t.Comments)
            .HasForeignKey(c => c.TaskItemId);

        // TaskComment → AppUser (user who commented)
        builder.Entity<TaskComment>()
            .HasOne(c => c.User)
            .WithMany()
            .HasForeignKey(c => c.UserId);

        // Project → AppUser (created by)
        builder.Entity<Project>()
            .HasOne(p => p.CreatedBy)
            .WithMany()
            .HasForeignKey(p => p.CreatedById);

        // Notification → AppUser
        builder.Entity<Notification>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserId);

        // ActivityLog → AppUser
        builder.Entity<ActivityLog>()
            .HasOne(a => a.CreatedBy)
            .WithMany()
            .HasForeignKey(a => a.CreatedById);*/
    }

}
