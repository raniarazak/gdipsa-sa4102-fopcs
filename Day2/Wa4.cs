using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa4
    {
        static void Main()
        {
            Console.WriteLine("Please enter the temperature in Centigrade!");
            string t = Console.ReadLine();
            double temp = Double.Parse(t);

            double f = 1.8 * temp + 32;

            Console.WriteLine("The temperature is {0} F", f);


        }
    }
}
