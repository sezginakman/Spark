using Spark.Cores;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Spark.Abstractions
{
    public abstract class Job : IJob
    {
        private JobSettings _setting;
        public abstract string Key { get; }
        public Dictionary<string, object> Parameter { get; set; }
        public abstract void CallBack();
        public void Execute()
        {
            OnEntry();
            if (_setting != null && _setting.IsActive)
                CallBack();
            OnExit();
        }
        public virtual void OnEntry()
        {
            dynamic settingService = Activator.CreateInstance("Spark.DataAccess", "Spark.DataAccess.JobSettingsService").Unwrap();
            _setting = settingService.GetLastByKey(Key);
            Parameter = _setting?.Parameter.ToDictionary(_ => _.Key, _ => _.Value);
        }
        public virtual void OnExit()
        {
            if(_setting==null) return;
            dynamic settingService = Activator.CreateInstance("Spark.DataAccess", "Spark.DataAccess.JobSettingsService").Unwrap();
            _setting.Parameter = Parameter.Select(_ => new KeyValue(_.Key, _.Value)).ToList();
            settingService.Save(_setting);
        }
    }
}
