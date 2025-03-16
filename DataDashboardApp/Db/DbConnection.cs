using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDashboardApp.Db;
    public abstract class DbConnection
    {
        private readonly string _connectionString;

    public DbConnection()
    {
        _connectionString = "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;";
    }
    protected SqlConnection GetConnection()
    {
        return new SqlConnection( _connectionString );
    }
    
}
   