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
            string name;
            name = PrintName();
            Console.WriteLine();
            Console.WriteLine("Greetings, {0}!", name);
        }

        private static string PrintName()
        {
            string name;
            Console.WriteLine("Please enter your name :");
            name = Console.ReadLine();
            return name;

        }
    }
}
