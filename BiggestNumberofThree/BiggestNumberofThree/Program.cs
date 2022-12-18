using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumberofThree
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first number!");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number!");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number!");

            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The biggest Number is" + Math.Max (Math.Max(firstNumber, secondNumber),thirdNumber));

            Console.ReadLine();

        }
    }
}
