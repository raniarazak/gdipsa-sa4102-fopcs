using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class quizwhile
    {
        static void Main()

        {
            string str;
            string pwd;
            int count = 0;

            do
            {
                Console.WriteLine("Enter PIN");
                str = Console.ReadLine();
                count++;

                pwd = "123456";
                if (str == pwd)
                {
                    Console.WriteLine("Correct PIN");

                }

                else
                {
                    switch (count)
                    {
                        case 1:
                            Console.WriteLine("Wrong password.Try again.You have 2 more tries");
                            break;

                        case 2:
                            Console.WriteLine("Wrong password. Try again. You have 1 more try");
                            break;
                        case 3:
                            Console.WriteLine("Too many tries. account locked!");
                            break;

                    }
                }
            } while (str != pwd && count < 3);

           
        }
    }
}
