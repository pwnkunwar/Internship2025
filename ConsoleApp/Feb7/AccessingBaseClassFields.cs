using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb7
{
    public class Building
    {
        public string Structure = "Concrete";
    }
    public class House : Building
    {
        public string Structure = "Residential";
        public void ShowStructure()
        {
            Console.WriteLine("Base Structure: "+ base.Structure);
            Console.WriteLine("Derived Structure: "+ Structure);
        }
    }
}
