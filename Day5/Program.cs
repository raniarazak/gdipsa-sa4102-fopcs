using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = InitializeArray();
            int userInput = GetInput();
            int count = CountInteger(myArray,userInput);
            PrintOutput(count, userInput);
        }

        //static int[,] theArray; 
        //declaring the array here o that it is accessible in all methods, this is a class variable
        

        static int[,] InitializeArray()
        {
            int[,] theArray = new int[,]
           {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
           };

            return theArray;

        }

        static int GetInput()
        {
            Console.WriteLine("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            return input;// must return sth when the data type of method is given as int; here int is the datatype of the 
                         // o/p that this methos returns.
        }

        static int CountInteger(int[,] anArray,int integerToFind)
        {
            int count = 0;

            for (int i = 0; i <= anArray.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= anArray.GetLength(1) - 1; j++)
                {
                    if (anArray[i, j] == integerToFind)
                    {
                        count = count + 1;
                    }
                }
            }

            return count;
        }

        static void PrintOutput(int count, int integerToFind)
        {
            if (count > 0)
            {
                Console.WriteLine("The number of {0} is {1}", integerToFind, count);
            }

            else
            {
                Console.WriteLine("There is no {0} in the array!", integerToFind);
            }
        }
    }
}
