using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We4
    {
        static void Main()
        {
            Console.WriteLine("Enter a number!");
            int n = Int32.Parse(Console.ReadLine());
            int p=0;

            for(int i=1; i<n; i++)
            {
                if (n % i == 0)
                {
                    p = p + i;
                }
            }

            if (p == n)
            {
                Console.WriteLine("Yes. {0} is a perfect number!", n);

            }

            else
            {
                Console.WriteLine("No. {0} is not a perfect number!", n);
            }
        }
    }
}
