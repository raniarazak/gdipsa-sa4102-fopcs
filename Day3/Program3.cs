using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program3
    {
        static void Main()
        {   //pgm to print a triangle of asteriks
            for (int i = 1; i<=7; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                 
                }

                Console.WriteLine(); // to change line
            }

        }
    }
}
