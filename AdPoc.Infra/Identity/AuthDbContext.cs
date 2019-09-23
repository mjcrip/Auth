using AppForms.Infrastructure.Identity.Entities;
using AppForms.Infrastructure.Shared.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdPoc.Areas.Identity.Data
{
    public class AuthDbContext : IdentityDbContext<AuthenticatedUser, 
                                                   AuthenticatedRole, 
                                                   int, 
                                                   IdentityUserClaim<int>, 
                                                   AuthenticatedUserRole, 
                                                   IdentityUserLogin<int>, 
                                                   IdentityRoleClaim<int>, 
                                                   IdentityUserToken<int>> 
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Auth");
            builder.Entity<AuthenticatedUserRole>(u => u.HasIndex(k => new { k.UserId, k.RoleId, k.OrganizationId }));

            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationService.SqlDataConnection;
            optionsBuilder.UseSqlServer(connectionString, r => r.EnableRetryOnFailure(2).CommandTimeout(120)).EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
