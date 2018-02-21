using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We1
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to find out its factorial!");
            double n = Double.Parse(Console.ReadLine());

            double f = 1;

            for (double i=1; i<=n; i++)
            {
                f = f * i;
            }

            Console.WriteLine("Factorial of {0} is {1} in increment", n, f);

            double d = 1;

            for (double i = n; i >= 1; i--)
            {
                d = d * i;
            }

            Console.WriteLine("Factorial of {0} is {1} in decrement", n, d);

            //program will fail for -ve numbers and decimal numbers and also 0




        }
    }
}
