using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wb5
    {
        static void Main()
        {
            Console.WriteLine("Enter a 3 digit number");
            int num = Convert.ToInt32(Console.ReadLine());

            int a = num / 100; 
            int b = (num % 100) / 10; 
            int c = (num % 100) % 10;

            // double a1 = Convert.ToInt32(a);
            // double b1 = Convert.ToInt32(b);
            //double c1 = Convert.ToInt32(c);

            double temp = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

            if (temp == num)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }



        }
    }
}
