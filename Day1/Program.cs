using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //writeline means writing the string and then change line
            Console.WriteLine("Hello");

            //WRITE MEANS WRITING THE STRING TO THE SCREEN and no next line
            Console.Write("Hello");

            string name;

            Console.WriteLine("Enter a name!");
            name = Console.ReadLine();
            // wait for user to key in a value and press enter
            //and assign the value into a variable called 'name'


            Console.WriteLine(name);

        }
    }
}
