using DotNetAssignment.Areas.Identity.Data;
using DotNetAssignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetAssignment.Data;

public class DotNetAssignmentContext : IdentityDbContext<DotNetAssignmentUser>
{
    public DotNetAssignmentContext(DbContextOptions<DotNetAssignmentContext> options)
        : base(options)
    {
    }

    public DbSet<Work> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Host=localhost;Database=AssignmentDB;username=postgres;password=Admin");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        modelBuilder.HasDefaultSchema("Assignments");
        modelBuilder.Entity<Work>(builder =>
        {
            builder.Property(x => x.Description)
            .HasMaxLength(500);
        });

        modelBuilder.Entity<IdentityUser>(builder =>
        {
            builder.ToTable(name: "User");
        });
        modelBuilder.Entity<IdentityRole>(builder =>
        {
            builder.ToTable(name: "Role");
        });
        modelBuilder.Entity<IdentityUserRole<string>>(builder =>
        {
            builder.ToTable("UserRoles");
        });
        modelBuilder.Entity<IdentityUserClaim<string>>(builder =>
        {
            builder.ToTable("UserClaims");
        });
        modelBuilder.Entity<IdentityUserLogin<string>>(builder =>
        {
            builder.ToTable("UserLogins");
        });
        modelBuilder.Entity<IdentityRoleClaim<string>>(builder =>
        {
            builder.ToTable("RoleClaims");
        });
        modelBuilder.Entity<IdentityUserToken<string>>(builder =>
        {
            builder.ToTable("UserTokens");
        });
    }
}
