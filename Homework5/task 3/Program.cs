using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
