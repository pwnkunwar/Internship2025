using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models;

namespace WinFormsApplication.Repositories
{
    public class ClientRepositry
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Client;Integrated Security=True;Trust Server Certificate=True";
    }

    public List<Client> GetClients()
    {
        var clients = new List<Client>();
        try
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM Clients", connection))
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var client = new Client();
                            client.id = reader.GetInt32(0);
                            client.firstName = reader.GetString(1);
                            client.lastName = reader.GetString(2);
                            client.email = reader.GetString(3);
                            client.phone = reader.GetString(4);
                            client.address = reader.GetString(5);
                            client.createdAt = reader.GetString(6);
                            clients.Add(client);
                        }
                    }
                }
            }
}
