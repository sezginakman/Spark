using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spark.Abstractions
{
    public interface IJob
    {
        string Key { get; }
        Dictionary<string, object> Parameter { get; set; }
        void CallBack();
    }
}
