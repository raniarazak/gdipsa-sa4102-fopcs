using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa3
    {
        static void Main()
        {
            Console.WriteLine("Enter your salary!");
            string temp = Console.ReadLine();
            double sal = Double.Parse(temp);
            
            double income = sal + ((10 / 100.0) * sal) + ((3 / 100.0) * sal);

            Console.WriteLine("Your total income is {0:C}", income);

        }
    }
}
