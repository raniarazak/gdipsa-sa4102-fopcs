using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh2
    {
        static void Main()
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6 };

            PrintArray(myArray);
        }

        static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
