using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            Array[0] = 0;
            Array[1] = 1;
            Array[2] = 2;
            Array[3] = 3;
            Array[4] = 4;
            Array[5] = 5;
            Array[6] = 6;
            Array[7] = 7;
            Array[8] = 8;
            Array[9] = 9;
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i * 10;
            }
            foreach (int element in Array)
                Console.WriteLine(element);
        }
    }
}
        
    

