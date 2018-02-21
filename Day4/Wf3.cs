using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day4
{
    class Wf3
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");
            s = s.Replace(".", "");
            s = s.Replace("\"", "");
            s = s.Replace("'", "");
            s = s.Replace("?", "");
            s = s.Replace(":", "");
            s = s.Replace(";", "");
            s = s.Replace("!", "");
            s = s.Replace(",", "");
            s = s.Replace(" \\", "");
            s = s.Replace("/", "");
            s = s.Replace("{", "");
            s = s.Replace("}","");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("[", "");
            s = s.Replace("]", "");
            s = s.Replace("|", "");
            s = s.Replace("\t", "");
            s = s.Replace("-", "");
            s = s.Replace("_", "");

            int flag = 1;

            for (int i = 0; i <= (s.Length / 2); i++)
            {
                if ((s.Substring(i, 1)) != (s.Substring(s.Length - (i + 1), 1)))
                {
                    flag = 0;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("This string is a PALINDROME!");

            }

            else
            {
                Console.WriteLine("NOT PALINDROME!");
            }


        }
    }
}
