using System;
using Microsoft.Extensions.DependencyInjection;

namespace Spark.ServiceCollectionResolver
{
    public static class ServiceResolver
    {
        //private static readonly Lazy<ServiceResolver> Lazy = new Lazy<ServiceResolver>(() => new ServiceResolver());
        //private ServiceResolver() { }
        private static Lazy<IServiceProvider> _lazyBuildServiceProvider = null;
        private static readonly Lazy<IServiceCollection> LazyServiceCollection = new Lazy<IServiceCollection>(() => new ServiceCollection());
        public static  IServiceCollection ServiceCollection => LazyServiceCollection.Value;
        private static IServiceProvider ServiceProvider => _lazyBuildServiceProvider.Value;
        public static void Build()
        {
            _lazyBuildServiceProvider = new Lazy<IServiceProvider>(() => ServiceCollection.BuildServiceProvider());
        }
        public static T GetService<T>() => ServiceProvider == null ? default : ServiceProvider.GetService<T>();
    }
}
