using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class quiz
    {
        static void Main()
        {

            string pwd = "123456";

            Console.WriteLine("Welcome to the bank of ISS!");

            for (int i = 0; i <= 2; i++)
            {

                
                Console.Write("Enter your PIN : ");
                string pin = Console.ReadLine();



                if (pin == pwd)
                {
                    Console.WriteLine("PIN accepted.You can access your account now!");
                    break;
                }

                else if(pin!=pwd && i < 2 )
                {
                    Console.WriteLine("Incorrect PIN.Please try again. You have {0} more tries!", 2 - i);

                }

                else if(pin!=pwd && i == 2)
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked!");
                }
            }

        }
    }
}
