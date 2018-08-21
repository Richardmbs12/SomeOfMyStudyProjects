using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Persistance.DataConnection
{
    public class SQLServerDataConnection : IDataConnection
    {
        public IDbConnection GetConnection(string connectionName)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString);
            return conn;
        }
    }
}
