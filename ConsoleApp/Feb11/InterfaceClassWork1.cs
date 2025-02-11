using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb11
{
   public interface IPlay
    {
        public void Play11();
    }
    public interface IStop
    {
        public void Stop11();
    }

    public class Playable11 : IPlay, IStop
    {
        public void Play11()
        {
            Console.WriteLine("Someone is playing");
        }

        public void Stop11()
        {
            Console.WriteLine("Someone is stop playing");
        }

    }
}
