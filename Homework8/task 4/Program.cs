using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            NumIsEvenIsOdd(num);

            
        }

         static  void NumIsEvenIsOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("isEven");
            }
            else
            {
                 Console.WriteLine("isOdd"); 

            }
        }
    }

}

