using BraveLantern.Swatcher;
using BraveLantern.Swatcher.Args;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using BraveLantern.Swatcher.Config;
using Spark.JobProvider;
using Spark.Helper;

namespace Spark.Watchdog
{
    public class JobWatchdog : IDisposable
    {
        private readonly JobAdapter _jobAdapter;
        private readonly Swatcher _swatcher;
        private readonly FolderWatchdogConfiguration _config;
        public JobWatchdog(IConfigureOptions<FolderWatchdogConfiguration> configuration, JobAdapter jobAdapter)
        {
            _jobAdapter = jobAdapter;
            _config = new FolderWatchdogConfiguration();
            configuration.Configure(_config);
            _swatcher = new Swatcher(_config);
        }
        public void Start()
        {
            if (_config.CanLoadAlAtStart)
                LoadAllJobs();
            _swatcher.ItemCreated -= SwatcherOnCreated;
            _swatcher.ItemCreated += SwatcherOnCreated;
            _swatcher.ItemDeleted -= swatcher_ItemDeleted;
            _swatcher.ItemDeleted += swatcher_ItemDeleted;
            _swatcher.Start().GetAwaiter().GetResult();
        }

        private void swatcher_ItemDeleted(object sender, SwatcherEventArgs e)
        {
            if (e.Name.Contains(".dll"))
                _jobAdapter.RemoveJobByPath(e.FullPath);
        }

        private void SwatcherOnCreated(object sender, SwatcherCreatedEventArgs e)
        {
            if (e.Name.Contains(".dll"))
                _jobAdapter.RegisterJobByPath(e.FullPath);
        }
        public void Dispose()
        {
            _swatcher.Stop().GetAwaiter().GetResult();
            _swatcher.Dispose();
        }
        public void LoadAllJobs()
        {
            var assemblyJobPath = Directory.GetFiles(_config.PathToWatch, "*.dll", SearchOption.AllDirectories);
            foreach (var path in assemblyJobPath)
            {
                if (File.Exists(path))
                {
                    var infos = AssemblyHelper.GetInfoByFilePath(path);
                    foreach (var info in infos)
                    {
                        AssemblyHelper.GetOrLoadByFilePath(path);
                        _jobAdapter.RegisterJobByPath(path);
                    }
                }
            }
        }
    }
}
