using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Spark.AssemblyProvider
{
   public static class DomainAssemblyResolverCollectionExtensions
    {
        public static IServiceCollection AddDomainAssemblyResolver(
            this IServiceCollection services,
            Action<DomainAssemblyResolverConfiguration> setupAction = null)
        {
            services.AddSingleton<DomainAssemblyResolver>();
            if (setupAction != null)
                services.ConfigureDomainAssemblyResolver(setupAction);
            return services;
        }

        public static void ConfigureDomainAssemblyResolver(
            this IServiceCollection services,
            Action<DomainAssemblyResolverConfiguration> setupAction)
        {
            services.Configure(setupAction);
        }
    }
}
