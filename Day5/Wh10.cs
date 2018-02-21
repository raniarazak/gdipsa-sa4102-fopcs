using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh10
    {
        static void Main()
        {
            Console.WriteLine("Enter no. of rows and columns of first array");
            int m = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());
            int[,] Array1 = new int[m, n];


            Console.WriteLine("Enter no. of rows and columns of second array");
            int p = Int32.Parse(Console.ReadLine());
            int q = Int32.Parse(Console.ReadLine());
            int[,] Array2 = new int[p, q];

            if (n == p)
            {
                Console.WriteLine("Enter elements of first array");
                
                for(int i = 0; i < Array1.GetLength(0);i++)
                {
                    for(int j=0;j<Array1.GetLength(1); j++)
                    {
                        Array1[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter elements of second array");

                for (int i = 0; i < Array2.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2.GetLength(1); j++)
                    {
                        Array2[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }

                int[,] OutputArray = MatrixMultiply(Array1, Array2);


                for (int i = 0; i < OutputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < OutputArray.GetLength(1); j++)
                    {
                        Console.Write("{0}    ",OutputArray[i, j]);
                    }
                }


            }

            else
            {
                Console.WriteLine("Cannot multiply these 2 matrices!");
            }





        }

        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int sum = 0;

            int[,] ProArray = new int[A.GetLength(0), B.GetLength(1)];

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {
                    for(int k = 0; k < A.GetLength(1); k++)
                    {
                        sum = sum + A[i, k] * B[k, j];
                        ProArray[i, j] = sum;
                    }

                    sum = 0;
                }

            }

            return ProArray;

        }
    }
}
