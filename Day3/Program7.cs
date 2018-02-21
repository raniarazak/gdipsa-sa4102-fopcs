using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program7
    {
        static void Main()
        {
            string s = "Hello World";
            string r = "";
           

            //to print each character on a single line
            //repeat i from 0 to the (length of s) - 1

            for(int i = 0; i <= s.Length - 1; i++)
            {
                if((s.Substring(i,1))!=" ")
                {
                    //get the ith char of s and then print the char
                    Console.WriteLine(s.Substring(i, 1));
                    //add the ith char of s to r
                    //r = r + s.Substring(i, 1);
                }
                

            }

            //Console.WriteLine(r);

            for(int i = s.Length-1; i>=0; i--)
            {
                if ((s.Substring(i, 1)) != " ")
                {
                    //get the ith char of s and then print the char
                    Console.WriteLine(s.Substring(i, 1));
                    //add the ith char of s to r
                    r = r + s.Substring(i, 1);
                }
            }

            Console.WriteLine(r);


        }
    }
}
