using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wb2
    {
        static void Main()
        {
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();

            Console.WriteLine("Specify your gender: M or F?");
            string gender = Console.ReadLine();

            Console.WriteLine("Specify your age!");
            int age = Convert.ToInt32(Console.ReadLine());

            if (gender == "M")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Uncle {0}", name);

                }

                else
                {
                    Console.WriteLine("Good Morning Mr. {0}", name);
                }
               
            }

            else if (gender == "F")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Aunty {0}", name);
                }

                else
                {
                    Console.WriteLine("Good Morning Ms. {0}", name);
                }

            }

            else
            {
                Console.WriteLine("Invalid gender! Please specify M or F for gender.");
            }
        }
    }
}
