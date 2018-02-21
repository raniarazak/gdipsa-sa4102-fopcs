using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program3
    {
        static void Main()
        {
            int x = Wh1.ReadInteger("Please enter x: ");
            int y = Wh1.ReadInteger("PLease enter y: ");

            int z = Wh1.ReadInteger();
            Console.WriteLine("You have entered {0} and {1}",x , y );
        }
    }
}
