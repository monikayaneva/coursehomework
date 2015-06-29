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
            int[] Array = { 3, 6, 7, 12, 22, 5 };
           int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                    sum = Array[i] + sum;   
                } 
            Console.WriteLine(sum);
            }
        }
    }

