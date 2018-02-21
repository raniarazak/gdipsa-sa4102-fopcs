using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n = 5.678 / 2.045;
            //double m = 0.56 * 0.21345;
            //Console.WriteLine(n);
            //Console.WriteLine("{0:#.##}",n);
            //Console.WriteLine("{0:#.##}", 0.3556);
            //Console.WriteLine(m);
            //Console.WriteLine("{0:#.##}", m);
            //Console.WriteLine("{0:0.##}", 2.56);
            //Console.WriteLine("{0:#.0#}", 1.00);
            //Console.WriteLine("{0:C10}", n);

            //string s = new string('*', 5);
            //Console.WriteLine("");

            //for(int i = 1; i <=6; i++)
            //{
            //    for(int k=1; k <= (6-i); k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j= 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");

            //}
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                int total_spaces = (2 * n - 1) - (2 * i - 1);

                for (int k = 1; k <= total_spaces / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                for (int k = 1; k <= total_spaces / 2; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
                //Console.Write("*");

            }

            //Random r = new Random();
            //int f;
            //do
            //{
            //    f = r.Next(1, 7);
            //    Console.WriteLine(f);
            //} while (f != 6);




            //Random r = new Random();
            //int f, g;
            //do
            //{
            //    f = r.Next(1, 7);
            //    g = r.Next(1, 7);
            //    Console.WriteLine("{0}  {1}", f, g);
            //} while (f != g);

            Random r = new Random();
            int f, g;
            do
            {
                f = r.Next(1, 7);
                //g = r.Next(1, 7);
                Console.WriteLine("{0}  {1}", f, g);
            } while (f != g);


        }
    }
}
