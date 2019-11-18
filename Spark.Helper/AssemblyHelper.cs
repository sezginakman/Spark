using dnlib.DotNet;
using Spark.AssemblyContainerService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Spark.Helper
{
    public static class AssemblyHelper
    {
        public static IEnumerable<AssemblyInfo> GetInfoByFilePath<T>(string path)
        {//TODO: PARAMETERS WİLL DEFAULT İNSERT
            var assemblyInfos = new SynchronizedCollection<AssemblyInfo>();
            var mod = ModuleDefMD.Load(FileHelper.FileToByteArray(path));
            var fileName = Path.GetFileName(path);
            foreach (var type in mod.GetTypes())
            {
                if (!(type.BaseType is null) && type.BaseType.FullName == typeof(T).FullName)
                {
                    var keyPropery = type.Properties.FirstOrDefault(_ => _.Name == "Key");
                    if (keyPropery != null)
                    {
                        dynamic method = keyPropery.GetMethod.MethodBody;
                        var keyValue = method.Instructions[0].Operand;
                        assemblyInfos.Add(new AssemblyInfo
                        {
                            Key = keyValue,
                            AssemblyFileName = fileName,
                            AssemblyFullName = type.FullName,
                            AssemblyName = type.Name,
                            AssemblyQualifiedName = type.AssemblyQualifiedName
                        });
                    }
                }
                //Console.WriteLine("  Base type: {0}", type.BaseType.FullName);
                //Console.WriteLine(mod.Assembly.FullName);
                //var fileName = Path.GetFileName(path);
                //Console.WriteLine(mod.Assembly.Name);
                //Console.WriteLine(fileName);
                //Console.WriteLine("Type: {0}", type.FullName);
                //Console.WriteLine("  Methods: {0}", type.Methods.Count);
                //Console.WriteLine("  Fields: {0}", type.Fields.Count);
                //Console.WriteLine("  Properties: {0}", type.Properties.Count);
                //Console.WriteLine("  Events: {0}", type.Events.Count);
                //Console.WriteLine("  Nested types: {0}", type.NestedTypes.Count);
                //if (type.Interfaces.Count > 0)
                //{
                //    Console.WriteLine("  Interfaces:");
                //    foreach (var iface in type.Interfaces)
                //        Console.WriteLine("    {0}", iface.Interface.FullName);
                //}
            }
            return assemblyInfos;
        }
        public static IEnumerable<AssemblyInfo> GetInfoByFilePath(string path)
        {
            var assemblyInfos = new SynchronizedCollection<AssemblyInfo>();
            var mod = ModuleDefMD.Load(FileHelper.FileToByteArray(path));
            var fileName = Path.GetFileName(path);
            foreach (var type in mod.GetTypes())
            {
                if (!(type.BaseType is null) && type.BaseType.FullName == "Spark.Abstractions.Job")
                {
                    var keyPropery = type.Properties.FirstOrDefault(_ => _.Name == "Key");
                    if (keyPropery != null)
                    {
                        dynamic method = keyPropery.GetMethod.MethodBody;
                        var keyValue = method.Instructions[0].Operand;
                        assemblyInfos.Add(new AssemblyInfo
                        {
                            Key = keyValue,
                            AssemblyFileName = fileName,
                            AssemblyFullName = type.FullName,
                            AssemblyName = type.Name,
                            AssemblyQualifiedName = type.AssemblyQualifiedName
                        });
                    }
                }
            }
            return assemblyInfos;
        }
        public static Assembly GetOrLoadByFilePath(string path)
        {
            try
            {
                var currentTime = DateTime.UtcNow;
                var uniqueId = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();
                var buffAssembly = dnlib.DotNet.AssemblyDef.Load(FileHelper.FileToByteArray(path));
                var assembly = AssemblyContainer.Assemblies.LastOrDefault(_ => _.Key.StartsWith(buffAssembly.Name)).Value;
                if (assembly == null)
                {
                    assembly = GetByFilePath(path);
                    AssemblyContainer.Assemblies.Add(buffAssembly.Name + "-" + uniqueId, assembly);
                }
                return assembly;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
            finally
            {

            }
        }

        public static T GetInstanceByName<T>(string assemblyFileName, string assemblyFullName, string typeName)
        {
            var assemblyName = Path.GetFileNameWithoutExtension(assemblyFileName) ?? "";
            var assembly = AssemblyContainer.Assemblies.LastOrDefault(_ => _.Key.StartsWith(assemblyName)).Value;
            if (assembly == null)
            {
                return (T)Activator.CreateInstance(assemblyName, assemblyFullName).Unwrap();
            }
            var typeNeed = typeof(T);
            foreach (var type in assembly.GetExportedTypes())
            {
                if (!typeNeed.IsAssignableFrom(type)) continue;
                if (type.FullName != assemblyFullName) continue;
                return (T)Activator.CreateInstance(type);
            }
            return default;
        }
        public static Assembly GetByFilePath(string path)
        {
            return Assembly.Load(FileHelper.FileToByteArray(path));
        }
    }
}
