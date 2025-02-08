using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb7
{
    public class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a shape....");
        }
    }
    public class Circle: Shape
    {
        public void DrawCircle()
        {
            base.Draw(); // calling base class method
            Console.WriteLine("Drawing a circle");
        }
    }
}
