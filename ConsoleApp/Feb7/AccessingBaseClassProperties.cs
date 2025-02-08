using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb7
{
    public class Device
    {
        public virtual string Model { get; set; } = "Generic Device";
    }
    public class Smartphone : Device
    {
        public override string Model
        {
            get
            {
                return base.Model + "This is a Smartphone";
            }
        }
    }
}
