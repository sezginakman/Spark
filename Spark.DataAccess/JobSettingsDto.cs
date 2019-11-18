using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Spark.Cores;

namespace Spark.DataAccess
{
    [Table("JobSetting")]
    public class JobSettingsDto
    {
        [Key]
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
    }
}
