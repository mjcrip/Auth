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
            RoleIds = new List<int>();
        }
        public int OrganizationId { get; set; }
        public int PersonId { get; set; }
        public bool RememberMe { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int AgencyId { get; set; }
        [NotMapped]
        public virtual List<AuthenticatedUserRole> AuthenticatedUserRoles { get; set; }
        [NotMapped]
        public List<int> RoleIds { get; set; }
        [NotMapped]
        public string AuthenticatedRolesList { get; set; }

    }
}
