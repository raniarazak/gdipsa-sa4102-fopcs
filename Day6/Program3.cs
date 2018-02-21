using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        static void Main()
        {
            int[] X = new int[] { 1, 2, 3 };
            Program.printArray(X);

            TimesTen(X);
            Program.printArray(X);

            //DoubleTheSize(X);
           // Console.WriteLine(X.Length);//3 wont change

            DoubleTheSize(ref X);
            Console.WriteLine(X.Length); //6

            X = DoubleTheSizeWithNoRef(X);
            Console.WriteLine(X.Length); //6
        }

        static void DoubleTheSize(ref int[] A)
        {
            int[] B = new int[A.Length * 2];
            for(int i=0;i<A.Length;i++)
            {
                B[i] = A[i];
            }
            A = B;
        }

        static int[] DoubleTheSizeWithNoRef(int[] A)
        {
            int[] B = new int[A.Length * 2];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            return B;
        }

        static void TimesTen(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * 10;
            }
        }

       
    }
}
