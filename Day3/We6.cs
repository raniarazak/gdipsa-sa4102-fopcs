using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We6
    {
        static void Main()
        {
            int p = 0;

            for (int i = 2; i <= 1000; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        p = p + j;
                        //Console.WriteLine("{0},{1},{2}", i, j, p);
                        
                        //else if (j == i - 1)// 1=7
                        //{
                        //    p = 0;
                        //}
                    }

                }

                if (p == i)
                {
                    Console.WriteLine(i);

                }

                p = 0;

                
            }
         
        }
    }
}
