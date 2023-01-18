using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            printSeries(number);
            Console.ReadLine();
        }

        public static void printSeries(int number)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber;

            if(number < 2)
            {
                Console.WriteLine("Please Enter number greater than 2");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber);
                for (int i = 2; i < number; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(" " + nextNumber);
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
        }
    }
}
