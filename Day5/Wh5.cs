using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh5
    {
        static void Main()
        {
            Console.WriteLine("NUMBER   HexaN (WRITTEN)  HExaN (BUILT-IN)");
            
            for(int i = 0; i <= 100; i++)
            {
               
                Console.WriteLine("{0}\t\t{1} \t\t {2}",i,IntToHexa(i),i.ToString("X"));
            }
            
        }


        static string IntToHexa(int input)
        {
            string rem="";
            int r;


            do
            {
                r = input % 16;
                input = input / 16;


                if (r >= 10)
                {
                    switch (r)
                    {
                        case 10:
                            rem = "A" + rem;
                            break;

                        case 11:
                            rem = "B" + rem;
                            break;

                        case 12:
                            rem = "C" + rem;
                            break;

                        case 13:
                            rem = "D" + rem;
                            break;

                        case 14:
                            rem = "E" + rem;
                            break;

                        case 15:
                            rem = "F" + rem;
                            break;
                    }


                }

                else

                    rem = r.ToString() + rem;

            } while (input != 0);


            return rem;


        }
    }
}
