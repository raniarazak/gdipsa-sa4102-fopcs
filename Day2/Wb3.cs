using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wb3
    {
        static void Main()
        {
            Console.WriteLine("Enter your marks!");
            double marks = Double.Parse(Console.ReadLine());

            if ((marks < 0) || (marks > 100))
            {
                Console.WriteLine("**ERROR**.\n Please enter marks between 0 and 100");
            }

            else if ((marks >= 0) && (marks < 40))
            {

                Console.WriteLine("You scored {0} marks which is F grade!", marks);
            }

            else if ((marks >= 40) && (marks < 60))
            {
                Console.WriteLine("You scored {0} marks which is C grade!", marks);
            }

            else if ((marks >= 60) && (marks < 80))
            {
                Console.WriteLine("You scored {0} marks which is B grade!", marks);

            }

            else if ((marks >= 80) && (marks <= 100))

            {
                Console.WriteLine("You scored {0} marks which is A grade!", marks);
            }

        }
    }
}
