using AppForms.Infrastructure.Identity.Entities;
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
            builder.HasDefaultSchema("identity");
            builder.Entity<AuthenticatedUserRole>(u => u.HasKey(k => new { k.UserId, k.RoleId, k.OrganizationId }));
            base.OnModelCreating(builder);
        }
    }
}
