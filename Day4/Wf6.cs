using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Wf6
    {
        static void Main()
        {
            Console.WriteLine("Enter your matriculation number!");
            string matri = Console.ReadLine();
            int[] num = new int[5];
            int sum=0;
            int t = 6;

            matri = matri.ToUpper();
            string a = matri.Substring(0, 1);
            string check = matri.Substring(6, 1);

            if (a!="A" || matri.Length != 7)
            {
                Console.WriteLine("Invalid Matriculation number. Please enter a number starting with 'A'!");

            }

            else
            {
                num[0] = Int32.Parse(matri.Substring(1, 1));
                num[1] = Int32.Parse(matri.Substring(2, 1));
                num[2] = Int32.Parse(matri.Substring(3, 1));
                num[3] = Int32.Parse(matri.Substring(4, 1));
                num[4] = Int32.Parse(matri.Substring(5, 1));

                for(int i = 0; i<num.Length  ; i++)
                {
                    sum = sum + num[i] * t;
                    t--;
                }

                int rem = sum % 5;

                switch (rem)
                {
                    case 0:

                        if (check=="O")
                        { Console.WriteLine("Valid Matriculation number"); }
                            else { Console.WriteLine("Invalid Matriculation number"); }
                        break;

                    case 1:

                        if (check == "P")
                        { Console.WriteLine("Valid Matriculation number"); }
                        else { Console.WriteLine("Invalid Matriculation number"); }
                        break;

                    case 2:
                        
                        if (check == "Q")
                        { Console.WriteLine("Valid Matriculation number"); }
                        else { Console.WriteLine("Invalid Matriculation number"); }
                        break;

                    case 3:
                        
                        if (check == "R")
                        { Console.WriteLine("Valid Matriculation number"); }
                        else { Console.WriteLine("Invalid Matriculation number"); }
                        break;

                    case 4:
                        
                        if (check == "S")
                        { Console.WriteLine("Valid Matriculation number"); }
                        else { Console.WriteLine("Invalid Matriculation number"); }
                        break;



                }





            }

        }
    }
}
