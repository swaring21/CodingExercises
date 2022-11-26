using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareOddsAndEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)

                {

                    Console.WriteLine("Your number is even!");

                    Console.ReadLine();


                }

            else
                {

                Console.WriteLine("Your number is odd!");

                Console.ReadLine();

                }
        }
    }
}
