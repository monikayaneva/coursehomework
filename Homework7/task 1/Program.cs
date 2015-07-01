using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {13, 8, 27, 63, 10},
                {7, 9, 12, 26, 48},
                {91, 87, 46, 30, 53}
            };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        
                            Console.WriteLine(matrix[i,j]);

                    }
                }
            }
        }
    }
    }

