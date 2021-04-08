using System.Data;
using System.Data.SqlClient;

namespace DesignPattersII.Exercise.Factories
{
    public sealed class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var connection = new SqlConnection("User id=root;Password=;Server=localhost;Database=banco");
            connection.Open();

            return connection;
        }
    }
}
