using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg8
    {
        static void Main()
        {
            int[,] Array = new int[,] { { 5, 1, 6, 2 },
                                        { 7, 9, 4, 3 },
                                        { 10, 8, 15, 17 },
                                        { 21, 23, 14, 11 },
                                        { 29, 45, 13, 25 } };
            int flag = 0;

            Console.WriteLine("Enter a number");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for(int j =0;j< Array.GetLength(1);j++)
                if (n == Array[i,j])
                {
                    Console.WriteLine("The number {0} is found at position [{1},{2}]", n, i + 1,j+1);
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
