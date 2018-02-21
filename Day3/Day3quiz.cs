using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Day3quiz
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Enter the number of items to purchase: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double p = n * 500;

            if ((p>2000) && (p <= 3000))
            {
                p = p - ((3 / 100.0) * p);
            }

            else if ((p>3000) && (p <= 6000))
            {
                p = p - ((5 / 100.0) * p);

            }

            else if (p > 6000)
            {
                p = p - ((8 / 100.0) * p);
            }

            Console.WriteLine("Please pay {0:C2}", p);


        }
    }
}
