using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Spark.Worker
{
    public interface IStartup
    {
        void ConfigureServices(IServiceCollection services);
    }
}
