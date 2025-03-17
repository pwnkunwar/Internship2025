using DataDashboardApp.Models;

namespace DataDashboardApp
{
    public partial class Form1 : Form
    {
        // Fields
        private Dashboard model;
        public Form1()
        {
            InitializeComponent();
            // Default - Last 7 days
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            btnEndDate.Value = DateTime.Now;
            btnlast7Days.Select();

            model = new Dashboard();
            LoadData();
        }


        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, btnEndDate.Value);
            if (refreshData == true)
            {
                lblNumberOfOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = "$" + model.TotalRevenue.ToString();
                lblTotalProfit.Text = "$" + model.TotalProfit.ToString();


                lblNumCustomers.Text = model.NumCustomers.ToString();
                lblNumSuppliers.Text = model.NumSuppliers.ToString();
                lblNumProducts.Text = model.NumProducts.ToString();


                productUnderStock.DataSource = model.UnderStockList;

                Console.WriteLine("Loaded View :)");

            }
            else Console.WriteLine("View not Loaded");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {

        }
    }
}
