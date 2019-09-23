using AdPoc.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForms.Infrastructure.Identity.Entities
{
    public class AuthenticatedUserRole : IdentityUserRole<int>
    {
        public int OrganizationId { get; set; }
    }
}
