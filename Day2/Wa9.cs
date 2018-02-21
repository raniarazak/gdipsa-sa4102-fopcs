using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Wa9
    {
        static void Main()
        {
            Console.WriteLine("What is the distance travelled?");
            double distance = Double.Parse(Console.ReadLine());

            double f = 2.40 + (distance * 0.40);
            Console.WriteLine(f);

            double fare = Math.Ceiling(f * 10);

            Console.WriteLine("The meter fare for your ride is {0}", fare/10.0);
        }
    }
}
