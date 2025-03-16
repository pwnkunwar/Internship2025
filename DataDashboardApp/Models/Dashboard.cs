using DataDashboardApp.Db;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDashboardApp.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get;private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string,int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<KeyValuePair<string, int>> GrossRevenueList { get; private set; }
        public int NumOrders { get;  set; }
        public decimal TotalRevenue { get;  set; }
        public decimal TotalProfit { get;  set; }

        public Dashboard()
        {
            
        }

        //Private methods
        private void GetNumberItems()
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    // Get Total Number of Customers
                    command.CommandText = "SELECT COUNT(id) FROM Customer";
                    NumCustomers = (int)command.ExecuteScalar();

                    // Get Total Number of Suppliers
                    command.CommandText = "SELECT COUNT(id) FROM Supplier";
                    NumSuppliers = (int)command.ExecuteScalar();

                    // Get Total Number of Products
                    command.CommandText = "SELECT COUNT(id) FROM Product";
                    NumProducts = (int)command.ExecuteScalar();


                    // Get Total Number of Orders
                    command.CommandText = @"SELECT COUNT(id) FROM [Order]" +
                                       " WHERE order_date BETWEEN @startDate AND @endDate";
                    command.Parameters.AddWithValue("@startDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.AddWithValue("@endDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumOrders = (int)command.ExecuteScalar();
                }
            }
        }

    }
}
