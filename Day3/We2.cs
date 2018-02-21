using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We2
    {
        static void Main()
        {

            Console.WriteLine("\t NO.\tINVERSE      SQUARE ROOT\t SQUARE");
            Console.WriteLine("    ------------------------------------------------------");
        
            for (double i = 1; i <= 10; i++)
            {
                double inv = 1 / i;
                double sr =  Math.Sqrt(i);
                double s = Math.Pow(i, 2);

                Console.WriteLine("\t {0:0.0} \t  {1:0.0##}\t\t {2:0.0##}\t\t  {3:0.0}", i, inv, sr, s);

            }
        }
    }
}
