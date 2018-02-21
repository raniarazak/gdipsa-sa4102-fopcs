using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program3
    {
        static void Main()
        {
            int[,,] A = new int[,,]
            {
                {
                    { 1,2},{ 3,4},{ 9,20}
                },

                {
                    { 5,6},{ 7,8},{ 9,21}
                },

                {
                    { 10,11},{ 12,13},{ 14,15}
                },

                {
                    { 16,17},{ 18,19},{ 23,22}
                }


            };//declare a 3-d array (4,3,2)

            Console.WriteLine(A[3, 2, 0]);
        }
    }
}
