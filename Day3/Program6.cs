using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program6
    {
        static void Main()
        {
            double length;
            bool succesfulParse;

            do
            {
                Console.Write("Please enter the length in cm (positive number)");
                string input = Console.ReadLine();
                //length = Double.Parse(input);
                succesfulParse = Double.TryParse(input, out length);
                //this TryParse method will give true if it succesfully parsed into double

                //Console.WriteLine(succesfulParse);

            } while (length < 0 || (succesfulParse == false));

            double inch = length / 2.54;

            Console.WriteLine("The length is {0} inch", inch);

        }
    }
}
