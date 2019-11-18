using Spark.DataAccess;
using Spark.JobProvider;

namespace Spark.JobUpdater
{
    public class BackgroundJob
    {
        public void Update(string key)
        {
            new JobAdapter(new JobSettingsService()).UpdateJobByKey(key);
        }
        public void Remove(string key)
        {
            new JobAdapter(new JobSettingsService()).RemoveJobByKey(key);
        }
    }
}
