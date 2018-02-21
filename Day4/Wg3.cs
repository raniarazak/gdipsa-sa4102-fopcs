using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg3
    {
        static void Main()
        {
            Console.WriteLine("How many students wrote the exams?");
            int nStu = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many subjects?");
            int nSub = Int32.Parse(Console.ReadLine());

            int[,] marks = new int[nStu, nSub];

            int sum = 0;

            Console.WriteLine("Enter the marks of each student");

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for(int j = 0; j < marks.GetLength(1); j++)
                {
                    marks[i, j] = Int32.Parse(Console.ReadLine());

                }
                
            }
            

            int[] TotalStudent = new int[marks.GetLength(0)];

            for(int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    sum = sum + marks[i,j];
                    TotalStudent[i] = sum;
                }

                sum = 0;
            }



            int[] TotalEachSub = new int[marks.GetLength(1)];
            int[] AvgOfSub = new int[marks.GetLength(1)];

            for (int i = 0; i < marks.GetLength(1); i++)
            {
                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    sum = sum + marks[j, i];
                    TotalEachSub[i] = sum;
                }

                AvgOfSub[i] = sum / marks.GetLength(0);
                sum = 0;
            }


            for (int i = 0; i < marks.GetLength(0); i++)
            {
                sum = sum + TotalStudent[i];
            }

            int ClassAvg=sum/marks.GetLength()





        }
    }
}
