using Microsoft.AspNetCore.Identity;

namespace AppForms.Infrastructure.Identity.Entities
{
    public class AuthenticatedUserRole : IdentityUserRole<int>
    {
        public int OrganizationId { get; set; }
    }
}
