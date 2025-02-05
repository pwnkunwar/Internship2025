using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Feb4
{
    public class FileHandlingRead
    {
        public void ReadFromFile(string filePath)
        {
            try
            {
                // check if the file exists 
                if(File.Exists(filePath))
                {
                    using(StreamReader reader = new StreamReader(filePath))
                    {
                        string content = reader.ReadToEnd();  // read all content
                        Console.WriteLine("File Content");
                        Console.WriteLine(content);
                    }
                }
                else
                {
                    Console.WriteLine("The file does not exists.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
