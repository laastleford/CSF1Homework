using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fizzbuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number to stop the sequence." );
            int userNumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }//for
        }
    }
}
