using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program3
    {
        static void Main(){

            int a = 5;
            int b = 3;
            Console.WriteLine(10 - 5 / a); //9
            Console.WriteLine(20 - 5 / -a); //11

            Console.WriteLine(10 - (5 / a)); //9
            Console.WriteLine((10 - 5) / a); //1

            Console.WriteLine(a == b); //False

            bool c = (a != b);
            Console.WriteLine(c); // true

            Console.WriteLine(a < a); //False

            Console.WriteLine((b > 1) && (a > 10)); // false

            Console.WriteLine(Math.Max(a, b)); // 5
            Console.WriteLine(Math.Min(a, b)); //3
            Console.WriteLine(Math.Ceiling(2.3)); //3
            Console.WriteLine(Math.Round(2.35671)); // 2
            Console.WriteLine(Math.Round(2.35671, 2)); //2.35, rounds to 2 decimal points





        

           


        }

    }
}
