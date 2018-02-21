using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh8
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of old array");
            int oldSize = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the size of new array");
            int newS = Int32.Parse(Console.ReadLine());

            if (oldSize > newS)
            {
                Console.WriteLine("Error. Please enter a size that is greater than old array");
            }

            else
            {
                int[] oldArray = new int[oldSize];
                Console.WriteLine("Enter old array values");

                for(int i = 0; i < oldArray.Length; i++)
                {
                    oldArray[i] = Int32.Parse(Console.ReadLine());
                }

                int[] OutputArray = ResizeArray(oldArray, newS);

                for(int i = 0; i <= OutputArray.Length - 1; i++)
                {
                    Console.Write("{0}   ", OutputArray[i]);
                }
            }



        }


        static int[] ResizeArray(int[] arr, int NewSize)
        {
            int[] NewArray = new int[NewSize];

            NewArray = SetArray(NewArray, 0);

            for(int i = 0; i < arr.Length; i++)
            {
                NewArray[i] = arr[i];
            }
            
            return NewArray;
        }



        static int[] SetArray(int[] Arr, int value)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = value;
            }

            return Arr;
        }
    }
}
