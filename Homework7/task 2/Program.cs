using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
