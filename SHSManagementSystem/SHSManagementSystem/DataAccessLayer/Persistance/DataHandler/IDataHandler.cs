using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Persistance.DataHandler
{
    public interface IDataHandler
    {
        SqlCommand GetCommand(string sql);
        DataSet Execute(string sql);
        int ExecuteNonQuery(string sql);
        int ExecuteStoredProcedure(string spName);
        DataSet ExecuteReturnStoredProcedure(string spName);
        int ExecuteStoredProcedure(SqlCommand command);
    }
}
