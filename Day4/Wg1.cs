using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wg1
    {
        static void Main()
        {
            int[] sales = new int[12];
            //int[] d = new int[12];
            
            int avg;
            int sum = 0;

            

            Console.WriteLine("Enter the sales of every month one by one!");


            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = Int32.Parse(Console.ReadLine());
            }

            int max = sales[0], min = sales[0];

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] > max)
                {
                    max = sales[i];
                }

                if (sales[i] < min)
                {
                    min = sales[i];
                }

                sum = sum + sales[i];

            }
            //Array.Copy(sales, d, sales.Length);

            //// Console.WriteLine("{0} {1}", sales[5], sales[10]);


            //for (int g = 0; g <= sales.Length - 2; g++) // sorting in descending order
            //{
            //    for (int r = g + 1; r <= sales.Length - 1; r++)
            //    {
            //        if (d[g] > d[r])
            //        {
            //            temp = d[r];
            //            d[r] = d[g];
            //            d[g] = temp;
            //        }
            //    }
            //}


            ////for (int i = 0; i < sales.Length; i++)
            //{
            //    Console.Write("{0}  ",d[i]);
            //}

            //for (int i=0; i < sales.Length; i++)
            //    {
            //        if (sales[i] == d[11])
            //        {
            //            Console.WriteLine("The maximum sales was in month {0}!", i + 1);
            //        }

            //        if (sales[i] == d[0])
            //        {
            //            Console.WriteLine("The minimum sales was in month {0}!", i + 1);
            //        }

            //        sum = sum + sales[i];

            //    }

                avg = sum / 12;

            Console.WriteLine("The maximum sales was in month {0}!", max);

            Console.WriteLine("The maximum sales was in month {0}!", min);

            Console.WriteLine("The average sales per month is {0:C2}", avg);



         



        }
    }
}
