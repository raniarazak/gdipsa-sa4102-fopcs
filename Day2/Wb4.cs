using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wb4
    {
        static void Main()
        {
            Console.WriteLine("Enter the distance you travelled!");
            double temp = Double.Parse(Console.ReadLine());
            double distance = (Math.Ceiling(temp * 10)) / 10;

            double rate;


            
            if (distance <= 0.5)
            {
                rate = 2.40;
            }

            else if ((distance> 0.5) && (distance <= 9))
            {
                rate = 2.40 + ((distance - 0.5) * 0.40);
            }

            else
            {
                rate = 2.40 + (8.5 * 0.40) + (distance - 9.0) * 0.50;
            }

            Console.WriteLine(rate);

        }

    }
}
