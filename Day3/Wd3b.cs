using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Wd3b
    {
        static void Main()
        {
            Random r = new Random();
            int secretnum = r.Next(0, 10);


            bool correctGuess = false;
            int count = 1;

            while (correctGuess == false)
            {//while the user has not guess correctly, keep asking

                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (input == secretnum.ToString())
                {
                    Console.WriteLine("Congrats!");
                    Console.WriteLine("You took {0} guesses to get it right!", count);

                    if (count <= 2)
                    {
                        Console.WriteLine("You're a wizard!");
                    }

                    else if ((count>2) && (count <= 5))
                    {
                        Console.WriteLine("You're a good guess!");
                    }

                    else
                    {
                        Console.WriteLine("You're lousy!");
                    }

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
