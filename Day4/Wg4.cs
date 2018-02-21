using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg4
    {
        static void Main()
        {
            Console.WriteLine("ENter size of array");
            int n =Int32.Parse(Console.ReadLine());

            int[] Array = new int[n];

            Console.WriteLine("Enter elements of array!");

            for(int i = 0; i < n; i++)
            {
                Array[i]=Int32.Parse(Console.ReadLine());
            }
            Console.Write("[");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0}", Array[i]);

                if (i == n - 1)
                {
                    Console.Write(" ]");
                }

                else
                {
                    Console.Write(",");
                }
            }
        }
    }
}
