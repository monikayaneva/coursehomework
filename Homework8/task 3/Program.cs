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
            Console.Write("Input a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int result1 = Multiplication(a, b, c);
            Console.Write("The result of multiplication is:");
            Console.WriteLine(result1);
            Console.WriteLine();
        }

        private static int Multiplication(int num1, int num2, int num3)
        {
            int result = num1 * num2 * num3;
            return result;

        }
    }
}