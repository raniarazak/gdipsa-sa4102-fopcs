using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program2
    {
        static void Main()
        {
            int a = 5;
            int b = 3;
            Console.WriteLine(+a); //5
            Console.WriteLine(-a); // -5

            int c = ++a; // increment a and assign the result into c
            Console.WriteLine(c); //6
            Console.WriteLine(a);//6

            a = 5;
            int d = a++; // assign a to d and then increment a
            Console.WriteLine(d); //5
            Console.WriteLine(a);//6

            // Can use breakpoints on the left side gray vertical space 
            //and then click start, to see the debugging

       
        }
    }
}
