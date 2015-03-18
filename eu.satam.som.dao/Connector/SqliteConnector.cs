using System.Data.Common;
using System.Data.SQLite;
using System.Dynamic;

namespace eu.satam.som.dao.Connector
{
    public class SqliteConnector : IConnector
    {
        public SqliteConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }

        public DbConnection GetOpennedConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }


    }

    public interface IConnector
    {
        string ConnectionString { get; }
    }
}