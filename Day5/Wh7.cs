using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh7
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array");
            int SizeOfArray = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value you want to set it with");
            int value = Int32.Parse(Console.ReadLine());

            int[] Array = new int[SizeOfArray];

            int[] newArray = SetArray(Array, value);

            for(int i = 0; i < newArray.Length; i++)
            {
                Console.Write("{0}  ", newArray[i]);
            }
            

        }
        static int[] SetArray(int[] Arr, int value)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = value;

            }

            return Arr;
        }
    }
}
