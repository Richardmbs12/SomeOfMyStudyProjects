using System.Data;


namespace DataAccessLayer.Persistance.DataConnection
{
    public interface IDataConnection
    {
        IDbConnection GetConnection(string connectionName);
    }
}
