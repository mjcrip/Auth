using AdPoc.Infra.Registrars;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace AppForms.Infrastructure
{
    public static class AutofacConfiguration
    {
        public static void ConfigureDependencies(this IServiceCollection services, ContainerBuilder builder)
        {
            new AdPocRegistrar().RegisterDependencies(builder);
        }
    }
}