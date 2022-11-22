using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number, and we'll add it to the next number you type!");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now type the next number to add to " + number + ".");

            int numberTwo = Convert.ToInt32(Console.ReadLine());

            int numberSum = number + numberTwo;

            Console.WriteLine("That Equals..." + numberSum + ".");

            Console.ReadLine();

        }
    }
}
