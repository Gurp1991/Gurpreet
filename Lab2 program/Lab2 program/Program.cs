using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_program
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
            return firstNumber + SecondNumber;
        }
    }
}



