using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class We5
    {
        static void Main()
        {
            bool p = true;

            for(int i = 5; i <= 10000; i++)
            {
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        p = false;
                        //Console.WriteLine("{0},{1}",i,j);
                        break;

                    }

                    
                    p = true;
                    //Console.WriteLine("inside for vdfvdfvsd   {0},{1}", i);
                }

                //Console.WriteLine("outside for nnnnnnn  {0}", i);

                if (p == true)
                {
                    Console.Write("\t{0}",i);
                }
            }
        }
    }
}
