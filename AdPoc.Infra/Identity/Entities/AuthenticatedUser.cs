using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForms.Infrastructure.Identity.Entities
{
    public class AuthenticatedUser : IdentityUser<int>
    {
        public AuthenticatedUser()
        {
            AuthenticatedUserRoles = new List<AuthenticatedUserRole>();
        }
        public int OrganizationId { get; set; }
        public int PersonId { get; set; }
        public bool RememberMe { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime ModifiedOn { get; set; }
        [NotMapped]
        public virtual List<AuthenticatedUserRole> AuthenticatedUserRoles { get; set; }
        
    }
}
