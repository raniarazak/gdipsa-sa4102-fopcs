using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa5
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of x!");
            string temp = Console.ReadLine();
            double x = Double.Parse(temp);

            double y = 5 * (Math.Pow(x, 2)) - (4 * x) + 3;
            Console.WriteLine(y);


        }
    }
}
