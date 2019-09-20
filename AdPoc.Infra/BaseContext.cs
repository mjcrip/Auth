using AppForms.Infrastructure.Shared.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdPoc.Infra
{
    public class BaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationService.SqlDataConnection;
             optionsBuilder.UseSqlServer(connectionString, r => r.EnableRetryOnFailure(2).CommandTimeout(120)).EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
