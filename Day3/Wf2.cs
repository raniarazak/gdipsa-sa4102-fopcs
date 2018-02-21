using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wf2
    {
        static void Main()
        {
            Console.WriteLine("Enter a string to check whether its a palindrome or not!");
            string s = Console.ReadLine();
            int flag = 1;

            for (int i = 0; i <= (s.Length/2); i++)
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
