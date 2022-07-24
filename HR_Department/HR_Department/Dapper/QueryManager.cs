using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace HR_Department.Dapper
{
    public static class QueryManager
    {
        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        public static void ExecuteDml(string procName, DynamicParameters paramList = null) 
        {
           using (SqlConnection conn = new SqlConnection(_connectionString)) 
            {
                conn.Open();
                conn.Execute(procName, paramList, commandType: CommandType.StoredProcedure);
            }
        }

        public static IEnumerable<T> ExecuteSelect<T>(string procName, DynamicParameters paramList = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                return conn.Query<T>(procName, paramList, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
