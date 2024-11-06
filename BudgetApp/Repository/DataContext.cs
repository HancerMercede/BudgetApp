using System.Data;
using System.Data.SqlClient;

namespace BudgetApp.Repository;

public class DataContext
{
    public IDbConnection CreateConnection() =>
        new SqlConnection(ConnectionString.Connection);
}
