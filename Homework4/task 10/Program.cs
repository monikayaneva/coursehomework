using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your points :");
            int numint = int.Parse(Console.ReadLine());
            if(numint >=1 && numint <= 9)
            { 
                if (numint >= 1 && numint<= 3)
	{
		 Console.WriteLine(numint * 5);
                }
                     
                    else if(numint >= 4 && numint <= 6)
                { 
                        Console.WriteLine(numint * 10);
	}

                else if (numint >= 7 && numint <= 9)
                {
                    Console.WriteLine(numint * 50);
                }
                    }
        }
    }
}
