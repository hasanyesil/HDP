using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dernek.DataAccess.Helper
{
    public static class DBHelper
    {

        private static OleDbConnection getConnection()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;

            return new OleDbConnection(connectionStr);
        }

        public static int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
        {
            using(var dbConn = getConnection())
            {
                using(var dbCmd =  dbConn.CreateCommand())
                {
                    dbConn.Open();
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sql;
                    
                    foreach(var param in parameters)
                    {
                        dbCmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    return dbCmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string sql)
        {
            using (var dbConn = getConnection())
            {
                using (var dbCmd = dbConn.CreateCommand())
                {
                    dbConn.Open();
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sql;

                    return dbCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
