using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AppForms.Infrastructure.Identity.Entities
{
    public class AuthenticatedRole : IdentityRole<int>
    {
        public List<AuthenticatedUserRole> AuthenticatedUserRoles { get; set; }
    }
}