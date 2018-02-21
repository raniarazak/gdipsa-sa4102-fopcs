using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa10
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of side a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side c");
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            if ((a + b < c) || (a + c < b) || (b + c < a))
            {
                Console.WriteLine(area);
                Console.WriteLine("Area cannot be computed as the area is negative!");

             }

            else
            {
                Console.WriteLine("The area of the traingle is {0}", area);
            }


        }
    }
}
