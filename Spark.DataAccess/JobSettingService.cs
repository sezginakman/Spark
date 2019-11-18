using System.Collections.Generic;
using Dapper;
using Spark.DataAccess.Util;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Configuration;
using Spark.Cores;

namespace Spark.DataAccess
{
    public class JobSettingsService
    {
        private const string ConnectionString =
            "Server=192.168.5.28;Database=Hangfire_DB;User Id=AppUser;Password=&WD#fF4w+";
        public JobSettingsService()
        {
            SqlMapper.AddTypeHandler(new GenericSqlMapperTypeHandler<ITimeExpressions>());
            SqlMapper.AddTypeHandler(new GenericSqlMapperTypeHandler<List<KeyValue>>());
        }
        public List<JobSettings> GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<JobSettings>(
                    $@"Select * From JobSetting")?.AsList();
            }
        }
        public JobSettings GetLastByKey(string key)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.QueryFirstOrDefault<JobSettingsDto>(
                    $@"Select TOP 1 * From JobSetting Where [Key] like '{key}' Order By Id Desc")?.Clone<JobSettings>();
            }
        }
        public void New(string key)
        {
            Save(JobSettings.Default(key));
        }
        public bool Save(JobSettings jobSettings)
        {
            var jobDto = jobSettings.Clone<JobSettingsDto>();
            using (var connection =
                new SqlConnection(ConnectionString))
            {
                if (jobSettings.Id > 0)
                    return connection.Update(jobDto);
                return connection.Insert(jobDto) > 0;
            }
        }
        public async Task<bool> SaveAsync(JobSettings jobSettings)
        {
            var jobDto = jobSettings.Clone<JobSettingsDto>();
            using (var connection =
                new SqlConnection(ConnectionString))
            {
                if (jobSettings.Id > 0)
                    return await connection.UpdateAsync(jobDto);
                return await connection.InsertAsync(jobDto) > 0;
            }
        }
        public void DeleteByFileName(string assemblyFileName)
        {
            using (var connection =
                new SqlConnection(ConnectionString))
                connection.Execute($@"Delete From JobSetting Where AssemblyFileName like '{assemblyFileName}'");
        }
        public void DeleteByKey(string key)
        {
            using (var connection =
                new SqlConnection(ConnectionString))
                connection.Execute($@"Delete From JobSetting Where [Key] like '{key}'");
        }
        public List<JobSettings> GetAllByFileName(string assemblyFileName)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<JobSettings>(
                    $@"Select * From JobSetting Where AssemblyFileName like '{assemblyFileName}%'")?.AsList();
            }
        }
    }
}
