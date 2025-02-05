using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb4
{
    public class FileHandling
    {
        public void WriteToFile(string filePath, string content)
        {
            try
            {
                // write content to the file
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                    Console.WriteLine("Content written to file sucessfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
