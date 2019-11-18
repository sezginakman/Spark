using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Spark.ServiceCollectionResolver;

namespace Spark.Watchdog
{
    public static class FolderWatchdogBuilderExtensions
    {
        public static IAppBuilder UseFolderWatchdog(
            this IAppBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));
            var folderWatchdog = ServiceResolver.GetService<JobWatchdog>();
            if (folderWatchdog == null)
                throw new InvalidOperationException(
                    "Serive collection could not resolve FolderWatchdog instance, Please configure service at Startup");
            OwinContext owinContext = new OwinContext(app.Properties);
            CancellationToken cancellationToken = owinContext.Get<CancellationToken>("host.OnAppDisposing");
            if (cancellationToken == new CancellationToken())
                cancellationToken = owinContext.Get<CancellationToken>("server.OnDispose");
            if (cancellationToken == new CancellationToken())
                throw new InvalidOperationException("Current OWIN environment does not contain an instance of the `CancellationToken` class neither under `host.OnAppDisposing`, nor `server.OnDispose` key.\r\nPlease use another OWIN host or create an instance of the `FileWatchdog` class manually.");
            cancellationToken.Register(new Action(folderWatchdog.Dispose));
            folderWatchdog.Start();
            return app;
        }
    }
}
