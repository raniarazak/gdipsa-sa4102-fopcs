using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wf1
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            int a=0, e=0, i=0, o=0, u=0;

            for( int j = 0; j < s.Length; j++)
            {
                if ((s.Substring(j, 1) == "a") || (s.Substring(j, 1) == "A"))
                {
                    a = a + 1;
                }

                if ((s.Substring(j, 1) == "e") || (s.Substring(j, 1) == "E"))
                {
                    e = e + 1;
                }

                if ((s.Substring(j, 1) == "i") || (s.Substring(j, 1) == "I"))
                {
                    i = i + 1;
                }

                if ((s.Substring(j, 1) == "o") || (s.Substring(j, 1) == "O"))
                {
                    o = o + 1;
                }

                if ((s.Substring(j, 1) == "u") || (s.Substring(j, 1) == "U"))
                {
                    u = u + 1;
                }


            }

            int total = a + e + i + o + u;
            Console.WriteLine("Total Vowels : {0}", total);
            Console.WriteLine("A : {0}", a);
            Console.WriteLine("E : {0}", e);
            Console.WriteLine("I : {0}", i);
            Console.WriteLine("O : {0}", o);
            Console.WriteLine("U : {0}", u);

        }
    }
}
