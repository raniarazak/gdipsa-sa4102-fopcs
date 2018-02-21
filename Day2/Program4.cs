using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine("Enter your result!");
            string input = Console.ReadLine();
            double result = Double.Parse(input);
            int grade = -1;

            if ((0<= result) && (result <= 40))
            {
                 grade = 1;
            }

            else if ((40 < result) && (result <= 70))
            {
                 grade = 2;
            }

            else if ((70 < result) && (result <= 100))
            {
                 grade = 3;
            }

            if (grade != -1)
            {
                Console.WriteLine("Your grade is {0}", grade);
            }
            else
            {
                Console.WriteLine("You entered an invalid number!");
            }
           
            // cannot use switch in this case because switch only supports string and integer, not double.

        }
    }
}
