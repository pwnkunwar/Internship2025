using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb20
{
    public static class BankApp
    {
        static string connectionString =
            "Data Source=DESKTOP-3SS2B66;Initial Catalog=BankDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        
        public static void App()
        {
            while (true)
            {
                Console.WriteLine("\nBank Management System");
                Console.WriteLine("1.Create New Account");
                Console.WriteLine("2.View Account Details");
                Console.WriteLine("3.Withdraw Amount");

                Console.WriteLine("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateNewAccount();
                        break;
                    case "2":
                        ViewBankInfo();
                        break;
                    case "3":
                        WithDrawMoney();
                        break;
                    case "4":
                        SendMoney();
                        break;
                        
                }

                static void CreateNewAccount()
                {
                    Console.WriteLine("Enter Your FullName");
                    string name = Console.ReadLine();
                    Console.WriteLine("Choose Account Type: 1.Savings 2.Current\n");
                    string type = Console.ReadLine();
                    string accountType = null;
                    if (type != "1" && type != "2")
                    {
                        Console.WriteLine("Invalid input");
                        CreateNewAccount();
                    }
                    if(type == "1")
                    {
                        accountType = "Savings";
                    }
                    if(type == "2")
                    {
                        accountType = "Current";
                    }
                    Console.WriteLine("Enter Balance");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    string accountNumber = Guid.NewGuid().ToString();
                    string createdDate = DateTime.Now.ToString();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO Accounts(AccountNumber,Name,AccountType,Balance,CreatedDate) VALUES(@accountNumber,@name,@accountType,@balance,@createdDate)";
                        using(SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AccountNumber",accountNumber);
                            cmd.Parameters.AddWithValue("@Name",name);
                            cmd.Parameters.AddWithValue("@AccountType", accountType);
                            cmd.Parameters.AddWithValue("@Balance", balance);
                            cmd.Parameters.AddWithValue("@CreatedDate", createdDate);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Console.WriteLine("Account Created Successfully!");
                }
                static void ViewBankInfo()
                {
                    Console.WriteLine("Enter Account Number:");
                    String accountNumber = Console.ReadLine();
                    string query = "SELECT * FROM Accounts WHERE AccountNumber = @accountNumber";
                    using(SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using(SqlCommand cmd =  new SqlCommand(query,conn))
                        {
                            cmd.Parameters.AddWithValue("@accountNumber",accountNumber);
                            using(SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if(!reader.HasRows)
                                {
                                    Console.WriteLine("No deatils found.");
                                    return;
                                }
                                Console.WriteLine("\n--Account Details---");
                                while(reader.Read())
                                {
                                    Console.WriteLine("AccountNumber: " + reader["AccountNumber"]);
                                    Console.WriteLine("Name: " + reader["Name"]);
                                    Console.WriteLine("AccountType " + reader["AccountType"]);
                                    Console.WriteLine("Balance: " + reader["Balance"]);
                                }
                            }
                        }
                    }
                }
                static void WithDrawMoney()
                {
                    decimal Balance;
                    decimal finalBalance=0;
                    Console.WriteLine("Please enter the account number: ");
                    string accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter the amount:");
                    decimal balance = decimal.Parse(Console.ReadLine());
                    if(balance < 0)
                    {
                        Console.WriteLine("Balance cannot be less than zero");
                    }
                    string query = "SELECT Balance FROM Accounts Where AccountNumber = @accountNumber";
                    using(SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using(SqlCommand cmd = new SqlCommand(query,connection))
                        {
                            cmd.Parameters.AddWithValue("@accountNumber",accountNumber);
                            using(SqlDataReader reader =cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    Console.WriteLine("Not found.");
                                    return;
                                }
                                Console.WriteLine("\n--Withdraw Money---");
                                while (reader.Read())
                                {
                                     finalBalance = Convert.ToDecimal(reader["Balance"]) - balance;
                                }
                            }
                            string query1 = "UPDATE Accounts SET Balance = @finalBalance WHERE AccountNumber = @accountNumber";
                            using(SqlCommand cmd1 = new SqlCommand(query1,connection))
                            {
                                cmd1.Parameters.AddWithValue("@finalBalance",finalBalance);
                                cmd1.Parameters.AddWithValue("@accountNumber",accountNumber);
                                int rowsAffected = cmd1.ExecuteNonQuery();
                                if(rowsAffected > 0)
                                {
                                    Console.WriteLine("Balance updated successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Account not found.");
                                }
                            }


                        }

                    }
                }
                static void SendMoney()
                {
                    decimal totalAmount = 0;
                    decimal AmountValue = 0;
                    Console.WriteLine("Enter the amount to be sent:");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    if(amount < 0)
                    {
                        Console.WriteLine("Amount cannot be less than zero");
                    }
                    Console.WriteLine("Enter the Receiver Account Number ");
                    string accountNumber = Console.ReadLine();
                    Console.WriteLine("Enter your Account Number");
                    string number = Console.ReadLine();
                    Console.WriteLine("Enter the Receiver Account Name");
                    string name = Console.ReadLine();   

                    using(SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT Balance FROM Accounts WHERE AccountNumber = @accountNumber AND Name = @name";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                            cmd.Parameters.AddWithValue("@name", name);
                            using(SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    Console.WriteLine("Not found.");
                                    return;
                                }
                                Console.WriteLine("\n--Deposit Money---");
                                while (reader.Read())
                                {
                                     totalAmount = Convert.ToDecimal(reader["Balance"]) + amount;
                                }
                            }
                        }
                        string query2 = "SELECT Balance FROM Accounts WHERE AccountNumber = @number";
                        using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                        {
                            cmd2.Parameters.AddWithValue("@number",number);
                            using(SqlDataReader reader2 = cmd2.ExecuteReader())
                            {
                                if (!reader2.HasRows)
                                {
                                    Console.WriteLine("Not found.");
                                    return;
                                }
                                Console.WriteLine("\n--Deposit Money---");
                                while (reader2.Read())
                                {
                                    if(Convert.ToDecimal(reader2["Balance"]) < amount)
                                    {
                                        Console.WriteLine("You do not have sufficient balance");
                                    }
                                    AmountValue = Convert.ToDecimal(reader2["Balance"]) - amount;
                                }
                            }

                        }
                        string query3 = "Update Accounts SET Balance = @AmountValue Where AccountNumber = @number";
                        using (SqlCommand cmd1 = new SqlCommand(query3, conn))
                        {
                            cmd1.Parameters.AddWithValue("@AmountValue", AmountValue);
                            cmd1.Parameters.AddWithValue("@number", number);
                            int rowsAffected = cmd1.ExecuteNonQuery();
                            
                        }
                        string query1 = "Update Accounts SET Balance = @totalAmount Where AccountNumber = @accountNumber";
                        using(SqlCommand cmd1 = new SqlCommand(query1,conn))
                        {
                            cmd1.Parameters.AddWithValue("@totalAmount",totalAmount);
                            cmd1.Parameters.AddWithValue("@accountNumber", accountNumber);
                            int rowsAffected = cmd1.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Amount sent successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Account not found.");
                            }
                        }


                    }
                }
            }
        }

    }
}
