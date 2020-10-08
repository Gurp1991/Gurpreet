
using System;

namespace ConsoleApp6new
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSum = AddNumbers(5, 4);

            Console.WriteLine(" sum of 5 and 4 is {0}", (firstSum));
        }
        //function declare here
        public static double AddNumbers(double firstNumber, double SecondNumber)
        { 
        return  firstNumber + SecondNumber;
        }
    }
}
