using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh9
    {
        static void Main()
        {
       
            for(int i = 5; i <= 1000; i++)
            {
                bool prime = isPrime(i);

                if (prime)
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool isPrime(int n)
        {
            
            bool p = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    p = false;

                }

            }

            return p;

        }
    }
}
