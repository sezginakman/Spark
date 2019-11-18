using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spark.DataAccess.Util
{
    public static class CloneObject
    {
        public static void Clone<T>(this T source, T target) where T : class, new()
        {

            if (source == null && target == null)
            {
                target= new T();
                return;
            }
            if (source == null || target == null)
            {
                target = new T();
                return;
            }
            var sourceFields = source.GetType().GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            foreach (var field in sourceFields)
                field.SetValue(target, field.GetValue(source));
        }
        public static T2 Clone<T2>(this object source)
            where T2 : class, new()
        {
            var target = new T2();
            if (source == null)
                return new T2();

            var sourceFields = source.GetType().GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            var targetFields = target.GetType().GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            foreach (var sourceField in sourceFields)
                foreach (var targetField in targetFields)
                    if (targetField.Name == sourceField.Name)
                        targetField.SetValue(target, sourceField.GetValue(source));
            return target;
        }
    }
}
