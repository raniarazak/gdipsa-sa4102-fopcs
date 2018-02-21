using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        static void Main()
        {

            bool cp = false;
            //a pgm that asks for password , the password is ISS
            //if the person gives wrong password 3 times,
            //the system will be locked

            //repeat 3 times
            //ask for pwd, if pwd correct, say congrats!. else say pwd is incorrect

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Password!");
                string input = Console.ReadLine();
                

                if (input == "ISS")
                {
                    Console.WriteLine("Congrats!");
                    cp = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Password is incorrect! Try again.");
                }
            }

                if(!cp) // i.e the condition is true i.e if cp is false
                {
                    Console.WriteLine("Game Over!");
                }


            
        }
    }
}
