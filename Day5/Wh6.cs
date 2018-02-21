using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh6
    {
        static void Main()
        {
            Console.WriteLine("Enter a string that you want to replace a character in ");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the character that you want to replace!");
            char[] c1 = Console.ReadLine().ToCharArray();

            Console.WriteLine("Enter the character that you want to set!");
            char[] c2 = Console.ReadLine().ToCharArray();

            string substituteString = Substitute(input, c1[0], c2[0]);

            Console.WriteLine(substituteString);


        }

        static string Substitute(string InputString, char c1ToReplace, char c2ReplaceWith)
        {
            char[] inputCharArray = InputString.ToCharArray();//converts a string into a char array

            for(int i = 0; i < inputCharArray.Length; i++)
            {
                if (char.ToLower(inputCharArray[i]) == char.ToLower(c1ToReplace))
                {
                    inputCharArray[i] = c2ReplaceWith;
                }
            }

            string outputString = new string(inputCharArray); // Converts a char array into a string

            return outputString;

        }
    }
}
