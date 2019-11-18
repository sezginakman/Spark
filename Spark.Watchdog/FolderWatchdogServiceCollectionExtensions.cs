using Microsoft.Extensions.DependencyInjection;
using System;

namespace Spark.Watchdog
{
    public static class FolderWatchdogServiceCollectionExtensions
    {
        public static IServiceCollection AddFolderWatchdog(
            this IServiceCollection services,
            Action<FolderWatchdogConfiguration> setupAction = null)
        {
            services.AddSingleton<JobWatchdog>();
            if (setupAction != null)
                services.ConfigureFolderWatchdog(setupAction);
            return services;
        }

        public static void ConfigureFolderWatchdog(
            this IServiceCollection services,
            Action<FolderWatchdogConfiguration> setupAction)
        {
            services.Configure(setupAction);
        }
    }
}
