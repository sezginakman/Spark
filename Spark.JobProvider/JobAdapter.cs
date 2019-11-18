using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Spark.Abstractions;
using Spark.AssemblyContainerService;
using Spark.Cores;
using Spark.DataAccess;
using Spark.Helper;

namespace Spark.JobProvider
{
    public class JobAdapter
    {
        private readonly JobSettingsService _settingService;

        public JobAdapter(JobSettingsService settingService)
        {
            _settingService = settingService;
        }
        public void RegisterJobByPath(string path)
        {
            var jobInfos = AssemblyHelper.GetInfoByFilePath<Job>(path);
            foreach (var info in jobInfos)
            {
                var settings = _settingService.GetLastByKey(info.Key) ?? JobSettings.Default(info.Key);
                settings.AssemblyFileName = info.AssemblyFileName;
                settings.AssemblyFullName = info.AssemblyFullName;
                settings.AssemblyName = info.AssemblyName;
                settings.AssemblyQualifiedName = info.AssemblyQualifiedName;
                new JobSettingsService().Save(settings);
                UpdateJobByKey(settings.Key);
            }
        }
        public void RemoveJobByPath(string path)
        {
            var fileName = Path.GetFileName(path);
            var name = Path.GetFileNameWithoutExtension(path) ?? "";
            var jobs = new JobSettingsService().GetAllByFileName(fileName);

            foreach (var recurringJob in jobs)
            {
                RecurringJob.RemoveIfExists(recurringJob.Key);
            }
            new JobSettingsService().DeleteByFileName(fileName);
            foreach (var key in AssemblyContainer.Assemblies.Keys.Where(_ => _.StartsWith(name)).ToList())
            {
                AssemblyContainer.Assemblies.Remove(key);
            }
        }
        public void UpdateJobByKey(string key)
        {
            var settings = _settingService.GetLastByKey(key);
            var job = AssemblyHelper.GetInstanceByName<Job>(settings.AssemblyFileName, settings.AssemblyFullName, settings.AssemblyName);
            if (job != null)
                switch (settings.JobType)
                {
                    case JobType.FireAndForget:
                        BackgroundJob.Enqueue(
                            () => job.Execute());
                        break;
                    case JobType.Delayed:
                        BackgroundJob.Schedule(
                            () => job.Execute(),
                            TimeSpan.FromDays(7));
                        break;
                    case JobType.Repeated:
                        RecurringJob.AddOrUpdate(job.Key, () => job.Execute(), settings.Schedule.ToString(), TimeZoneInfo.Local);
                        break;
                    default:
                        return;
                }
        }
        public void RemoveJobByKey(string key)
        {
            var jobs = new JobSettingsService().GetLastByKey(key);
            RecurringJob.RemoveIfExists(key);
            new JobSettingsService().DeleteByKey(key);
        }
    }
}
