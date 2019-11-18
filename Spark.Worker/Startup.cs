using Hangfire;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using Spark.Worker.Services;
using System;
using System.Configuration;
using System.IO;
using Hangfire.Storage;
using Spark.AssemblyProvider;
using Spark.JobProvider;
using Spark.ServiceCollectionResolver;
using Spark.Watchdog;
using Spark.DataAccess;

[assembly: OwinStartup(typeof(Spark.Worker.Startup))]

namespace Spark.Worker
{
    public class Startup : IStartup
    {
        public void Configuration(IAppBuilder app)
        {
            //ServiceResolver.ServiceCollection.AddSingleton<IStartup, Startup>();
            ConfigureServices(ServiceResolver.ServiceCollection);
            ServiceResolver.Build();
            app.UseDomainAssemblyResolver();
            app.UseHangfireServer(new BackgroundJobServerOptions
            {
                //ServerName = $"{Environment.MachineName}.{Guid.NewGuid().ToString()}",
                ServerName = $"{Environment.MachineName}.NewVersion",
                WorkerCount = Environment.ProcessorCount * 2
            }).UseHangfireDashboard();
            app.UseFolderWatchdog();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<JobSettingsService>();
            services.AddTransient<JobAdapter>();
            services.AddHangfire(_ =>
            {
                _.UseSqlServerStorage("Server=192.168.5.28;Database=Hangfire_DB;User Id=AppUser;Password=&WD#fF4w+");
            });
            services.AddFolderWatchdog(_ =>
            {
                _.Id = 1;
                _.PathToWatch = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Jobs\\");
                _.ChangeTypes = WatcherChangeTypes.Created| WatcherChangeTypes.Deleted;
                _.IsRecursive = true;
                _.LoggingEnabled = false;
                _.CanLoadAlAtStart = true;
            });
            services.AddDomainAssemblyResolver(_ =>
            {
                _.JobPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Jobs\\");
                _.BasePath = AppDomain.CurrentDomain.BaseDirectory;
            });
            
        }
    }
}
