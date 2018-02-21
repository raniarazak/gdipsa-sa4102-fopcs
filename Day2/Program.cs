using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.WriteLine(a * b);

            int c = a - b;
            Console.WriteLine(a / b); // ans is 1 because it is integer division
            Console.WriteLine(a % b); // ans is 2 - remainder of 5 divide by 3

            double aa = 5.0;
            double bb = 3.0;

            Console.WriteLine(aa * bb); // gives 15 because we didnt give any formatting. so c#
                                        // uses defalut formatting.
            Console.WriteLine(aa - bb);
            Console.WriteLine(aa / bb); //1.666666666..67  

            // c# will do an integer division ony if both numbers are int. All other cases it
            // will do normal division

            Console.WriteLine(a / 2); // 2
            Console.WriteLine(a / 2.0); // 2.5

            Console.WriteLine((double)a / 2); // 2.5

            Console.WriteLine(aa % bb); //2.0
        


        }
    }
}
