using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa6
    {
        static void Main()
        {
            Console.WriteLine("Enter x cordinate of first point");
            double x1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y cordinate of first point");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter x cordinate of second point");
            double x2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter y cordinate of second point");
            double y2 = Double.Parse(Console.ReadLine());



            double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)) ;

            Console.WriteLine("The distance between these two points are {0}", distance);



        }
    }
}
