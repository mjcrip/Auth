using System;
using System.Collections.Generic;
using System.Text;
using AdPoc.Areas.Identity.Data;
using Autofac;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AdPoc.Infra.Registrars
{
    public class IdentityRegistrar
    {
        internal void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<AuthDbContext>().InstancePerLifetimeScope();
        }
    }
}
