using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FruitLoop1_2
    {
        static void Main(string[] args)
        {

            string[] fruits = new string[] { "banana", "orange", "apple", "mango", "guava", "lychee" };
            string[] numberOfPeriods = new string[6];


            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
                for (int x = 0; x < i; x++)
                {
                    Console.Write(".");
                    
                }
                Console.WriteLine();
            }//for















            //for (int outerIndex = 0; outerIndex < 10; outerIndex++ )
            //{
            //    Console.WriteLine("I like Lines!");
            //    for(int innerIndex = 0; innerIndex <= outerIndex; innerIndex++)
            //    {
            //        Console.WriteLine("There are " + outerIndex + " things in the stuff");
            //    }
            //}

            //Console.Read();

            
        }
    }
}
