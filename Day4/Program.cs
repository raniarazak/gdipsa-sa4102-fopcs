using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[3];

            A[0] = 100;
            A[1] = 200;
            A[2] = 300; //INDEX OUT OF BOUND exception means that we have tried to access a storage that doesnt exist.
                        //in this case the array size is 3, and so if we A[3]=400, it is more than A size 

            int[] B = new int[3] { 1, 2, 3}; // have to supply all values if we initaialize in this form,

            int[] BB = new int[] { 1, 2, 3, 5, 6, 7, 8 }; //C# will count for you ,so dont need to give array size

            int i= 4;
            int[] C = new int[i]; //C is and array of a 4 int.
            i= 5; //size of C doesnt change

            int[] D = new int[4];
            D = B;// this is not a copy operation
            Console.WriteLine(D[2]); //3

            D[2] = 300;
            Console.WriteLine(D[2]);//300
            Console.WriteLine(B[2]);//300

            int[] E;
            E = B;// this is not a copy operation
            Console.WriteLine(E[2]); //3

            E[2] = 300;
            Console.WriteLine(E[2]);//300
            Console.WriteLine(B[2]);//300

            int[] F = new int[4];
            Array.Copy(B, F, B.Length);// different types of Array.copy...check
            Console.WriteLine(F[1]);
            F[1] = 200;
            Console.WriteLine(F[1]);
            Console.WriteLine(B[1]);

        }
    }
}
