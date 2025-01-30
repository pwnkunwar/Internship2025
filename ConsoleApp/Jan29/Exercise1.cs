using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Jan29
{
    public static class Exercise1
    {
        public static void MatrixAddition()
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int cols1 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows1, cols1];

            for (int i=0; i< rows1; i++)
            {
                for(int j=0; j< cols1; j++)
                {
                    Console.Write($"Enter value for {i} row,{j} column of matrix1 ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the number of rows: ");
            int rows2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int cols2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[rows2, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Enter value for {i} row,{j} column of matrix2");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] addition = new int[rows1,cols1];
            for(int i=0; i< rows2; i++)
            {
                for(int  j=0; j <cols2; j++)
                {
                    addition[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            Console.WriteLine("Resultant Matrix after Addition:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(addition[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
