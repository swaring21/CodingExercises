using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop1to10
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int rndInt = rnd.Next(0, 10);

            Console.WriteLine(rnd.Next(1, 10));

            Console.WriteLine(rnd.Next(1, 10));

            Console.WriteLine(rnd.Next(1, 10));

            Console.WriteLine (rnd.Next(1, 10));

            Console.WriteLine(rnd.Next(1, 10));

            Console.ReadLine();

        }
    }
}
