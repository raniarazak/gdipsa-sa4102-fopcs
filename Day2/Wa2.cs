using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa2
    {
        static void Main()
        {
            Console.WriteLine("Enter a decimal number");
            string temp = Console.ReadLine();
            double num = Double.Parse(temp);

            Console.WriteLine("The square root of {0} is {1:0.000}", num, Math.Sqrt(num));

        }
    }
}
