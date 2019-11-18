using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Spark.Abstractions;
using Spark.Helper;
using Spark.JobProvider;

namespace Spark.AssemblyProvider
{
    public class DomainAssemblyResolver : IDisposable
    {
        private readonly SemaphoreSlim _semaphoreSlimForJobs;
        private readonly DomainAssemblyResolverConfiguration _configuration;
        public DomainAssemblyResolver(IConfigureOptions<DomainAssemblyResolverConfiguration> configuration)
        {
            _configuration = new DomainAssemblyResolverConfiguration();
            configuration.Configure(_configuration);
            _semaphoreSlimForJobs = new SemaphoreSlim(1, 1);
        }
        public void Start()
        {
            AppDomain.CurrentDomain.AssemblyResolve -= Resolve;
            AppDomain.CurrentDomain.AssemblyResolve += Resolve;
        }

        private Assembly Resolve(object sender, ResolveEventArgs args)
        {
            var asmName = new AssemblyName(args.Name);
            var assemblyJobPath = Directory.GetFiles(_configuration.JobPath, asmName.Name + ".dll", SearchOption.AllDirectories).FirstOrDefault() ?? "";
            if (File.Exists(assemblyJobPath))
                return AssemblyHelper.GetOrLoadByFilePath(assemblyJobPath);
            var assembliesBasePath = Directory.GetFiles(_configuration.BasePath, asmName.Name + ".dll", SearchOption.AllDirectories).FirstOrDefault() ?? "";
            if (File.Exists(assembliesBasePath))
                return AssemblyHelper.GetOrLoadByFilePath(assembliesBasePath);
            return null;
        }

       
        public void Dispose()
        {
        }
    }
}
