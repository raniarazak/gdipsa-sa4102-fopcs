using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3 };
            int[] B = SquareArray(A);
            printArray(B);

            int[] C = IncrementArray(A);
            printArray(C);

            int[] D = ApplyOperation(A, Square);
            printArray(D);

            int[] E = ApplyOperation(A, TimesTen);
            printArray(E);

            int[] F = ApplyOperation(A, Sqrt);
            printArray(E);

            MickeyMouse Times100 = delegate (int x) { return x * 100; };
            int[] M = ApplyOperation(A, Times100);//100,200,300

            MickeyMouse times100b = delegate (int x) { return TimesN(x, 100); };
            int[] G = ApplyOperation(A, times100b);//100,200,300

            int[] H = ApplyOperation(A, delegate (int x) { return x * 100; });

            int[] I = ApplyOperation(A, (int x) => { return x * 100; });//lambda expression



        }

        static int Square(int x) { return x * x; }

        static int Increment(int x) { return x + 1; }

        static int TimesTen(int x) { return x * 10; }

        static int TimesN(int x, int n) { return x * n; }

        static double Sqrt(double x) { return Math.Sqrt(x); }//not mickey mouse,wont work
                                                             // coz double
        static int Sqrt(int x) { return (int)Math.Round(Math.Sqrt(x)); }



        delegate int MickeyMouse(int b); //lets refer to this kind of method that accepts 1 int n returns 1 int
                                         //as Mickey mouse
        static int[] ApplyOperation(int[] A, MickeyMouse ops)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {

                newArray[i] = ops(A[i]);// applying ops to each of the element

            }

            return newArray;
        }

        //this method will peform square operation fro each element of the array

        static int[] SquareArray(int[] A)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {

                newArray[i] = A[i] * A[i];

            }

            return newArray;
        }

        static int[] IncrementArray(int[] A)
        {
            int[] newArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {

                newArray[i] = A[i] + 1;

            }

            return newArray;
        }



        public static void printArray(int[] A)
        {
            Console.Write("[");
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write("{0},",A[i]);
            }
            Console.WriteLine("]");

        }
    }
}
