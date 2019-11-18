using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BraveLantern.Swatcher.Config;

namespace Spark.Watchdog
{
    public class FolderWatchdogConfiguration : ISwatcherConfig
    {
        public int? Id { get; set; }
        public string PathToWatch { get; set; }
        public WatcherChangeTypes ChangeTypes { get; set; }
        public bool IsRecursive { get; set; }
        public bool LoggingEnabled { get; set; }
        public SwatcherItemTypes ItemTypes => SwatcherItemTypes.All;
        public SwatcherNotificationTypes NotificationTypes => SwatcherNotificationTypes.All;
        public bool CanLoadAlAtStart { get; set; }
    }
}
