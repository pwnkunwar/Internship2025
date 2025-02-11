using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb11
{
     public interface IPlayable
    {
        public void Play();
        public void Stop();
    }
    public class Playable : IPlayable
    {
        public void Play()
        {
            Console.WriteLine($"Someone is playing!");
        }

        public void Stop()
        {
            Console.WriteLine($"Someone is Stop Playing!");
        }
    }
}
