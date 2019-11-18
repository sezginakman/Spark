using Hangfire;

namespace Spark.JobUpdater
{
    public class EnqueueJob
    {
        private readonly string _hangfireServerAddress;

        public EnqueueJob(string hangfireServerAddress)
        {
            _hangfireServerAddress = hangfireServerAddress;
        }
        public void Update(string key)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage(_hangfireServerAddress);
            Hangfire.BackgroundJob.Enqueue(
                () => new BackgroundJob().Update(key));
        }
        public void Remove(string key)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage(_hangfireServerAddress);
            Hangfire.BackgroundJob.Enqueue(
                () => new BackgroundJob().Remove(key));
        }
    }
}
