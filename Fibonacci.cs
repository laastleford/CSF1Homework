using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following is a Fibonacci sequence....");
            Console.WriteLine("Please provide a number to stop the sequence.");
            int userEndNumber = int.Parse(Console.ReadLine());
            
            int previousNumber = 1;
            int newNumber = 1;

            while (newNumber < userEndNumber)
            {

                newNumber = newNumber + previousNumber;
                Console.WriteLine(newNumber);
            }




        }
    }
}
