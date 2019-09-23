using AdPoc.Areas.Identity.Data;
using Autofac;

namespace AdPoc.Infra.Registrars
{
    public class AdPocRegistrar
    {
        public void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<AdPocContext>().InstancePerLifetimeScope();
            builder.RegisterType<AuthDbContext>().InstancePerLifetimeScope();
        }
    }
}
