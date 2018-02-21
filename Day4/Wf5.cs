using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wf5
    {
        static void Main()
        {
            string[] n = new string[] { "John", "Venkat", "Mary", "Victor", "Benny" };
            int[] m = new int[] { 63, 29, 75, 82, 55 };
            int temp;
            string temps;

            int[] t = new int[5];
            string[] d = new string[5];
            Array.Copy(m, t, m.Length);
            Array.Copy(n, d, n.Length);

            Console.WriteLine("List in descending order of marks: ");


            for (int g = 0; g <= t.Length - 2; g++) // sorting in descending order
            {
                for (int r = g + 1; r <= t.Length - 1; r++)
                {
                    if (t[g] < t[r])
                    {
                        temp = t[r];
                        t[r] = t[g];
                        t[g] = temp;
                    }
                }
            }

            for (int i = 0; i < m.Length; i++)// for loop for printing name and marks in descending order of marks!
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (m[j] == t[i])
                    {
                        Console.WriteLine("{0}  {1}", n[j], t[i]);
                        break;
                    }

                }
            }

            Console.WriteLine();

            Console.WriteLine("List in alphabetical order of name: ");

            // (b) part of ques5

            for (int g = 0; g <= n.Length-2; g++) //sorting in alphabetical order
            {
                for(int r = g+1; r <= n.Length-1; r++)
                {
                    if (String.Compare(d[g],d[r])==1)
                    {
                        temps = d[r];
                        d[r] = d[g];
                        d[g] = temps;

                    }
                }
            }


            for (int i = 0; i < n.Length; i++) //for loop for printing the alphabetically sorted name along with their
                                                //corresponding marks!
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] == d[i])
                    {
                        Console.WriteLine("{0}  {1}", d[i], m[j]);
                        break;
                    }

                }
            }



        }
    }
}
