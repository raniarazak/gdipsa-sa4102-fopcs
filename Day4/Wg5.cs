using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg5
    {
        static void Main()
        {
            int[] Array = new int[10] { 5, 1, 6, 2, 7, 9, 4, 3, 10, 8 };
            int flag = 0;

            Console.WriteLine("Enter a number");
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                if (n == Array[i])
                {
                    Console.WriteLine("The number {0} is found at position {1}", n, i + 1);
                    flag = 1;
                }

            }

            if (flag == 0)
            {
                Console.WriteLine("-1");
            }


        }
    }
}
