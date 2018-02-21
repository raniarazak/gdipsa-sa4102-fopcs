using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wb1
    {
        static void Main()
        {
            Console.WriteLine("Enter your name!");
            string name = Console.ReadLine();

            Console.WriteLine("Specify your gender: M or F?");
            string gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }

            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms. {0}", name);

            }
           
            else
            {
                Console.WriteLine("Invalid gender! Please specify M or F for gender.");
            }

        }
    }
}
