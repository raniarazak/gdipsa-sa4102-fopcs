using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program2
    {
        static void Main()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine(Multiply(x, y));

            //swap(x, y);// This will not swap x and y coz just the values of x & y 
                       //is copied and a and b is swapped. Not x nd y
                       // so here we should pass the valuse by reference instead of value
                       // using the syntax ref

            swap(ref x, ref y);

            Console.WriteLine("{0}, {1}", x, y);
        }

        static int Multiply(int a,int b)
        {
            return a * b; // here when we call Multiply(x,y),we are copying value of 
                          // x and y into a and b
        }

        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
