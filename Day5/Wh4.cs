using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh4
    {
        static void Main()
        {
            Console.WriteLine("Enter first string");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string input2 = Console.ReadLine();

            int flag = FindWord(input1, input2);

            if (flag>0)
            {
                Console.WriteLine("TRUE. The starting position is {0}",flag);
            }

            else
            {
                Console.WriteLine("FALSE....{0}",flag);
            }


        }
        static int FindWord(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i, 1) == s2.Substring(0, 1))
                {
                    int a = s1.Substring(i, s1.Length - i).Length; //Remaining length of s1 starting from index i

                    if (a >= s2.Length && (s1.Substring(i, s2.Length) == s2))
                    {
                        return i;
                    }


                }
            }

            return -1;
        }
    }
}
