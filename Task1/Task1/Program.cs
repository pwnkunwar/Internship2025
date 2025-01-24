// See https://aka.ms/new-console-template for more information
using Task1;


while(true)
{
    Console.WriteLine("1. Enter User Details");
    Console.WriteLine("2. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Details.UserDetails();
    }
    else if (choice == "2")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}
