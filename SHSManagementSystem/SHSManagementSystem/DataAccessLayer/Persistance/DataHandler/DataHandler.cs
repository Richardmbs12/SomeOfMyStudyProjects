using DataAccessLayer.Persistance.DataConnection;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Persistance.DataHandler
{
    public class DataHandler : IDataHandler
    {
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
                }
        }

        public DataHandler(IDataConnection dataConnection)
        {
            connection = dataConnection.GetConnection("SHSManagementDB") as SqlConnection;
        }

        public SqlCommand GetCommand(string sql)
        {
            SqlCommand sqlCmd = new SqlCommand(sql, Connection);
            return sqlCmd;
        }

        public DataSet Execute(string sql)
        {
            DataSet dataSet = new DataSet();
            SqlCommand cmd = GetCommand(sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataSet);
            cmd.Connection.Close();
            return dataSet;
        }

        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public int ExecuteStoredProcedure(string spName)
        {
            SqlCommand cmd = GetCommand(spName);
            cmd.CommandType = CommandType.StoredProcedure;
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public int ExecuteStoredProcedure(SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = Connection;
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public DataSet ExecuteReturnStoredProcedure(string spName)
        {
            DataSet dataSet = new DataSet();
            SqlCommand command = new SqlCommand(spName, Connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataSet);
            command.Connection.Close();
            return dataSet;
        }
    }
}
