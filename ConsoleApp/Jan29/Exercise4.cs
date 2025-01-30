using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise4
    {
        public static void JaggedA()
        {
            float[][] studentsMarks = new float[3][];
            studentsMarks[0] = new float[] { 80,90,100 };
            studentsMarks[1] = new float[] {70,85 };
            studentsMarks[2] = new float[] { 88,76,96,89};
            
            for(int i=0; i< studentsMarks.Length; i++)
            {
                    float average = 0;
                Console.Write("Student " + (i + 1)+" Average:");
                foreach(float mark in studentsMarks[i])
                {
                    if (mark >= 0.5f) // Only include valid marks
                    {
                        average += mark;
                    }
                }
                
                    Console.Write(average / studentsMarks[i].Length + "\n");


            }

        }
    }
}
