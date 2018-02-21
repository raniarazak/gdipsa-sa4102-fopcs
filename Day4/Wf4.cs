using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wf4
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence!");
            string str = Console.ReadLine();
            string temps,tempc;
            char [] c;

            string[] s = str.Split(' ');

            for(int i = 0; i < s.Length; i++)
            {
                s[i]=s[i].ToLower();

               // Console.WriteLine(s[i]);

                temps = s[i].Substring(0, 1);

                //Console.WriteLine(temps);
                tempc = temps.ToUpper();

                //Console.WriteLine(tempc);

                char t = Char.Parse(temps);

                //Console.WriteLine(t);

                c = new char[]{t};

                s[i] = s[i].TrimStart(c);
                s[i] = tempc + s[i];

               // Console.WriteLine(s[i]);

                Console.Write("{0} ", s[i]);
               



            }



        }
    }
}
