using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Spark.ServiceCollectionResolver;

namespace Spark.AssemblyProvider
{
   public static class DomainAssemblyResolverBuilderExtensions
    {
        public static IAppBuilder UseDomainAssemblyResolver(
            this IAppBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));
            var domainAssemblyResolver = ServiceResolver.GetService<DomainAssemblyResolver>();
            if (domainAssemblyResolver == null)
                throw new InvalidOperationException(
                    "Serive collection could not resolve FolderWatchdog instance, Please configure service at Startup");
            OwinContext owinContext = new OwinContext(app.Properties);
            CancellationToken cancellationToken = owinContext.Get<CancellationToken>("host.OnAppDisposing");
            if (cancellationToken == new CancellationToken())
                cancellationToken = owinContext.Get<CancellationToken>("server.OnDispose");
            if (cancellationToken == new CancellationToken())
                throw new InvalidOperationException("Current OWIN environment does not contain an instance of the `CancellationToken` class neither under `host.OnAppDisposing`, nor `server.OnDispose` key.\r\nPlease use another OWIN host or create an instance of the `DomainAssemblyResolver` class manually.");
            cancellationToken.Register(new Action(domainAssemblyResolver.Dispose));
            domainAssemblyResolver.Start();
            return app;
        }
    }
}
