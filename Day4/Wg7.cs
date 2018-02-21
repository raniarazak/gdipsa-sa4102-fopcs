using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg7
    {
        static void Main()
        {
            string[] name = new string[] { "Dennis", "Leslie", "Amanda", "Howard", "Lucy", "Raniah", "Shamil" };
            int[] score = new int[] { 54, 76, 23, 89, 65, 45, 87 };

            for(int g = 0; g <= name.Length - 2; g++)
            {
                for(int r = g + 1; r <= name.Length - 1; r++)
                {
                    if (string.Compare(name[g], name[r]) == 1)
                    {
                        string temp = name[r];
                        name[r] = name[g];
                        name[g] = temp;

                        int t = score[r];
                        score[r] = score[g];
                        score[g] = t;
                    }
                }
            }

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("{0}\t\t{1}", name[i], score[i]);
            }

        }
    }
}
