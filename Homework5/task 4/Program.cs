using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i % (3 * 7) != 0)
                
                    Console.WriteLine(i);
                
            }
        }
    }
}
