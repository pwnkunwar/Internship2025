using DataDashboardApp.Db;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public List<RevenueByDate> GrossRevenueList { get; private set; }
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

        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"Select OrderDate, sum(TotalAmount)
                                           from[Order]
                                           where OrderDate between @fromDate and @toDate
                                            group by OrderDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalProfit = TotalRevenue * 0.2m;
                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    reader.Close();

                    //Group by Days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    // Group by Weeks
                    else if(numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0,order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    else 
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                            into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }
        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top 5 P.ProductName, sum(OrderItem.Quantity) as Q
                                          from OrderItem
                                          inner join Product P on P.Id = OrderItem.ProductId
                                          inner [Order} O on O.Id = OrderItem.OrderId 
                                           where OrdreDate between @fromDate and @endDate
                                           group by P.ProductName
                                            order by Q desc";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get UnderStock
                    command.CommandText = @"select ProductName, Stock 
                                           from Product
                                            where Stock <= 6 and IsDiscontinued = 0";
                    while(reader.Read())
                    {
                        UnderStockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }

        // Public methods 
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                return true;
            }
            else
            {
                Console.WriteLine("Date not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }

    }
}
