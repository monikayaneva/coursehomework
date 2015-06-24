using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++)
            {
                if (a % 7 == 0 || a % 11 == 0)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }
}
