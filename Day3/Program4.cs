using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program4
    {
        static void Main()
        { //number guessing game

            //pick a number from 1-9

            //Random is a data type. it is a class
            //left side is the declaration, and the right side is initialization
            // we are creating a new random object here and giving it into r

            Random r = new Random();
            int secretnum = r.Next(1, 10); // will pick a num that is >= 1 and <10 i.e 1-9

            
            bool correctGuess = false;

            while (correctGuess == false)
            {//while the user has not guess correctly, keep asking

                Console.Write("enter your guess: ");
                string input = Console.ReadLine();

                if (input == secretnum.ToString())
                {
                    Console.WriteLine("Congrats!");
                    correctGuess = true;
                }

                else
                {
                    Console.WriteLine("Wrong!Try again!");
                }

                    }


        }
    }
}
