using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class W3
    {
        static void Main()
        {
            string temp;
            int num;

            Console.WriteLine("Enter a number that you want to square!");

            //COnsole.ReadLine() only takes string/char type
            temp = Console.ReadLine();

            //Converts string to int
            num = Convert.ToInt32(temp);

            Console.WriteLine(num * num);
            


        }
    }
}
