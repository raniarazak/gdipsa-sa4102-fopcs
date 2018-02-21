using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class W4
    {
        static void Main()
        {
            string temp;
            double num;

            Console.WriteLine("Enter a decimal number that you want to square!");

            //COnsole.ReadLine() only takes string/char type
            temp = Console.ReadLine();

            //Converts string to double number 
            num = Convert.ToDouble(temp);

            Console.WriteLine(num * num);

        }
    }
}
