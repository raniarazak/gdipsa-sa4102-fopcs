using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //counting starting from 0 in variable i, each time increase by 1,
            //while i<10
            //we want i to go from 0..9
            for (int i=0; i<10; i++) // initialization;condition;increment/decrement
            {
                Console.WriteLine(i);
            }

            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
