using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how to long array:");
            long n = long.Parse(Console.ReadLine());
            long[] Array = new long[n];
            Array[0] = 1;
            Array[1] = 1;

            for (int i = 2; i < Array.Length; i++)
            {
                Array[i] = Array[i - 1] +  Array[i - 2];

            }
            foreach  (long element in Array)
            {
                Console.WriteLine();
                Console.WriteLine(element);  
            }
        }
    }
}
