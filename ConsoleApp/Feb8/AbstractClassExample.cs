using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb8
{
    public abstract class Appliance
    {
        public string Brand { get; set; }
        public Appliance(string brand)
        {
            Brand = brand;
        }

        // Abstract method (must be implemented in derived classes)
        public abstract void TurnOn();

        // Non-abstract method
        public void DisplayBrand()
        {
            Console.WriteLine($"Applicance Brand: {Brand}");
        }
    }
    // Derived class WashingMachine
    public class WashingMachine : Appliance
    {
        public WashingMachine(string brand): base(brand) 
        {
            
        }
        public override void TurnOn()
        {
            Console.WriteLine($"{Brand} Washing Mahine is now running!");
        }
    }
}
