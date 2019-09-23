using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AppForms.Infrastructure.Identity.Entities
{
    public class AuthenticatedRole : IdentityRole<int>
    {
        public const string ProgramManager = "Program Manager";
        public const string Administrator = "Administrator";
        public const string ProgramUser = "Program User";
        public const string PaymentsUser = "Payments User";
        public const string FinancialUser = "Financial User";
        public const string ExternalUser = "External User";
        public const string ProgramAuditor = "Program Auditor";
        public const string FinancialAuditor = "Financial Auditor";
        public const string LCCUser = "LCC User";
        public const string LCCUserView = "LCC User View";
        public const string AgencyBillingDefault = "Agency Billing Default";
        public const string AgencyBillingBackup = "Agency Billing Backup";
    }
}