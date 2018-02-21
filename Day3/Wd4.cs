using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wd4
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to find out the square root!");
            double n = Double.Parse(Console.ReadLine());
            
            Random r = new Random();
            double G = (r.NextDouble()*(n-1))+1;

            Console.WriteLine("random {0:0.000}", G);


            if (n == 0)
            {
                Console.WriteLine("{0:0.000}", n);
            }


            else if ((G * G) == n)
            {
                Console.WriteLine("blaaaa {0:0.000}",G);
            }

            else
            {
                while ( !((Math.Abs((G * G) - n)) < 0.00001) )
                {
                    G = (G + (n / G)) / 2;
                    Console.WriteLine("loop {0:0.000}", G);

                }

                Console.WriteLine("The square root is {0:0.000}",G);
                
            }


            
        

        }
    }
}
