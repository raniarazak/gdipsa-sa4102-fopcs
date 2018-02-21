using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wd3a
    {
        static void Main()
        {
            Random r = new Random();
            int secretnum = r.Next(0, 10);


            bool correctGuess = false;
            int count=1;

            while (correctGuess == false)
            {//while the user has not guess correctly, keep asking

                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (input == secretnum.ToString())
                {
                    Console.WriteLine("Congrats!");
                    Console.WriteLine("You took {0} guesses to get it right!", count);

                    correctGuess = true;
                }

                else
                {
                    Console.WriteLine("Wrong!Try again!");
                    count = count + 1;

                }

            }
        }
    }
}
