using Microsoft.Data.SqlClient;
using System.Data;

namespace DataGridView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShowData_Click(object sender, EventArgs e)
		{
			String connectionString = "Data Source=DESKTOP-3SS2B66;Initial Catalog=DataGridView;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();

			String Query = "SELECT * FROM Names";
			SqlCommand command = new SqlCommand(Query, connection);
			var reader = command.ExecuteReader();	

			DataTable dataTable = new DataTable();
			dataTable.Load(reader);

			dataGridView1.DataSource = dataTable;

			connection.Close();
		}
	}
}
