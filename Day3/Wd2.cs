using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wd2
    {
        static void Main()
        {
            double a, b;


            Console.WriteLine("Enter first number!");
            string i1 = Console.ReadLine();

            bool s1 = Double.TryParse(i1, out a);

            double tempa = a;


            Console.WriteLine("Enter second number!");
            string i2 = Console.ReadLine();

            bool s2 = Double.TryParse(i2, out b);

            double tempb = b;



            if ((a == b) || (s1==false) || (s2==false))
            {
                Console.WriteLine("Please enter 2 distinct numbers!");
                
            }

            if ((a != b) && (s1 == true) && (s2==true))
            {

                while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }

                    else if (a < b)

                    {
                        b = b - a;
                    }
                }

                Console.WriteLine("The HCF of {0} and {1} is {2}", tempa, tempb, a);

                double lcm = (tempa * tempb) / a;

                Console.WriteLine("The LCM of {0} and {1} is {2}", tempa, tempb, lcm);

            }
            
           

            

            


        }
    }
}
