using DataDashboardApp.Db;
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
    }
}
