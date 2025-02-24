using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb23
{
    public static class CRUDEntity
    {
        public static void Execute()
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1.Create Product");
                Console.WriteLine("2.Read Products");
                Console.WriteLine("3.Update Product");
                Console.WriteLine("4.Delete Product");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateProduct();
                        break;
                    case "2":
                        ReadProducts();
                        break;
                    case "3":
                        UpdateProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }
        }
        static void CreateProduct()
        {
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                var product = new Product
                {
                    Name = name,
                    Price = price
                };
                using (var context = new AppDbContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            Console.WriteLine("Product created successfully!");
        }
        static void ReadProducts()
        {
            using(var context = new AppDbContext())
            {
                var products = context.Products.ToList();
                if(products.Any())
                {
                    Console.WriteLine("Products:");
                    foreach(var product in products)
                    {
                        Console.WriteLine($"{product.Id}: {product.Name} - ${product.Price}");
                    }
                }
                else
                {
                    Console.WriteLine("No products found");
                }
            }
        }
        static void UpdateProduct()
        {
            Console.WriteLine("Enter Product ID to update: ");
            if(int.TryParse(Console.ReadLine(), out int id))
            {
                using(var context = new AppDbContext())
                {
                    var product = context.Products.Find(id);
                    if(product != null)
                    {
                        Console.WriteLine($"Enter the new name (current: {product.Name})");
                        string newName = Console.ReadLine();
                        Console.WriteLine($"Enter new price (currrent: {product.Price})");
                        if(decimal.TryParse(Console.ReadLine(),out decimal newPrice))
                        {
                            product.Name = newName;
                            product.Price = newPrice;
                            context.Products.Update(product);
                            context.SaveChanges();
                            Console.WriteLine("Product updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid price.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product not found");
                    }
                   
                }
            }else
            {
                Console.WriteLine("Invalid Id");
            }
        }
        static void DeleteProduct()
        {
            Console.WriteLine("Enter product ID to delete");
            if(int.TryParse(Console.ReadLine(), out int Id))
            {
                using(var context = new AppDbContext())
                {
                    var product = context.Products.Find(Id);
                    if(product !=null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        Console.WriteLine("Product deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }
    }
    }
