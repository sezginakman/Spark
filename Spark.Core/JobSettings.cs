using System.Collections.Generic;

namespace Spark.Cores
{
    public class JobSettings
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Key { get; set; }
        public bool IsActive { get; set; }
        public JobType JobType { get; set; }
        public ITimeExpressions Schedule { get; set; }
        public List<KeyValue> Parameter { get; set; }
        public string AssemblyQualifiedName { get; set; }
        public string AssemblyFullName { get; set; }
        public string AssemblyName { get; set; }
        public string AssemblyFileName { get; set; }
        public string Error { get; set; }
        public static JobSettings Default(string key)
        {
            return new JobSettings
            {
                Id = -1,
                Group = "New Jobs",
                Key = key,
                IsActive = false,
                JobType = JobType.Repeated,
                Schedule = new Never(),
                Parameter = new List<KeyValue>() { new KeyValue("test", "value") }
            };
        }
    }
}
