using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan30;
    public interface IVehicle
    {
        void Start();
        void Stop();
    }
    public class MotorVehicle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping...");
        }
    }

