using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30
{
    public  class Vehicle
    {
        public  string Brand {  get; set; }

        public  void Start()
        {
            Console.WriteLine($"{Brand} is starting ...");
        }
    }

    public  class Car : Vehicle
    {
        public int Wheels { get; set; } = 4;

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving with {Wheels} wheels");
        }
    }


}
