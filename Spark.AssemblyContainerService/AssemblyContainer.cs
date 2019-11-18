using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spark.AssemblyContainerService
{
    public sealed class AssemblyContainer
    {
        private static readonly Lazy<SortedList<string, System.Reflection.Assembly>>
            Lazy = new Lazy<SortedList<string, System.Reflection.Assembly>>
                (() => new SortedList<string, System.Reflection.Assembly>());
        public static SortedList<string, System.Reflection.Assembly> Assemblies => Lazy.Value;
        public static void Clear()
        {
            Assemblies.Clear();
        }
    }
}
