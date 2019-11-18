using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.Annotations;
using Microsoft.Extensions.DependencyInjection;

namespace Spark.Worker.Services
{
    public static class HangfireService
    {
        public static IServiceCollection AddHangfire(
            [NotNull] this IServiceCollection services,
            [NotNull] Action<IGlobalConfiguration> configuration)
        {
            configuration(GlobalConfiguration.Configuration);
            return services;
        }
    }
}
