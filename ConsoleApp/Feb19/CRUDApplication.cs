using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb19
{
    public static class CRUDApplication
    {
        static string connectionString = "Data Source=DESKTOP-3SS2B66;Initial Catalog=ProductDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";


        public static void App()
        {
            while (true)
            {
                Console.WriteLine("\nProduct Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit Product");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        ViewProducts();
                        break;
                    case "3":
                        UpdateProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        Console.WriteLine("Exisiteing...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. try again");
                        break;
                }

                static void AddProduct()
                {
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter product price:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price))
                    {
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();
                                string query = "INSERT INTO Products (Name, Price) VALUES (@Name,@Price)";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Name", name);
                                    cmd.Parameters.AddWithValue("@Price", price);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            Console.WriteLine("Product added successfully!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid price");
                    }
                }
                static void ViewProducts()
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT * FROM Products";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    Console.WriteLine("No products found.");
                                    return;
                                }

                                Console.WriteLine("\n--- Product List ---");
                                while (reader.Read())
                                {
                                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Price: ${reader["Price"]}");
                                }
                            }
                        }
                    }
                }

            }
            static void UpdateProduct()
            {
                Console.Write("Enter Product ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.Write("Enter new name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter new price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "UPDATE Products SET Name=@Name, Price=@Price WHERE Id=@Id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@Price", price);

                                int rows = cmd.ExecuteNonQuery();
                                if (rows > 0)
                                    Console.WriteLine("Product updated successfully!");
                                else
                                    Console.WriteLine("Product not found.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid price. Update failed.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID.");
                }
            }

            static void DeleteProduct()
            {
                Console.Write("Enter Product ID to delete: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE Id=@Id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                                Console.WriteLine("Product deleted successfully!");
                            else
                                Console.WriteLine("Product not found.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID.");
                }
            }
        }
    }
}
