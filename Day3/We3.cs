using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We3
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to know if its a prime number!");
            int n = Int32.Parse(Console.ReadLine());
            bool p = true;

            for(int i=2 ; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    p = false;

                }
                                                     
            }

            if (p == false)
            {
                Console.WriteLine("Not prime!");
            }

            else
            {
                Console.WriteLine("Prime!");
            }

        }
    }

}
