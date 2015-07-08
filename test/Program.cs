using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
         
           
            Console.Write("Enter a number between 2 and 9: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            int[,] matrix = new int[rows,cols];
            Console.WriteLine("Enter the numbers of the matrix:");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                   
                    Console.Write("{0},{1} =",row,col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
            int[] array = new int[rows * cols];
            int count = 0;
            
            
      

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
             
                    array[count++] = matrix[col, row];
                }
            }
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                Console.WriteLine(array[i]);  
            }
            Console.WriteLine("The sum of numbers in array is: " + sum);
            }
            }
        }
    
