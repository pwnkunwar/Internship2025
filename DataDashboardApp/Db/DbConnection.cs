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
        _connectionString = "Data Source=DESKTOP-3SS2B66;Initial Catalog=DataDashboardApp;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
    protected SqlConnection GetConnection()
    {
        return new SqlConnection( _connectionString );
    }
    
}
   