using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Wh1
    {
        public static int ReadInteger(string prompt) //public so that this method can be called by other classes within the same project
        {
            bool isParseDone;
            int userInput;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isParseDone = Int32.TryParse(input, out userInput);

            } while (isParseDone == false);

            return userInput;


        }

        public static int ReadInteger() // this method is for ppl who dont want to give any message inside their ReadIntegr
        {
            return ReadInteger("PLease enter an integer: ");
            
        }
    }
}
