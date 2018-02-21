using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wd1
    {
        static void Main()
        {
            double n;
            string input;
            bool Success;
            do
            {
                Console.WriteLine("Please enter an integer number");
                input = Console.ReadLine();
                Success = Double.TryParse(input, out n);



            } while (n != 88 || (Success == false) );


            Console.WriteLine("Lucky you!");

        }
    }
}
