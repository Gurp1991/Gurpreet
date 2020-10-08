using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1

{    class Program
    { }
    
        public static void Main(String[] args)
        {

            Console.WriteLine("Enter first number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double n2 = double.Parse(Console.ReadLine());
            double sum = Addition(n1, n2);

            Console.WriteLine(" addition of two numbers {0}", sum(n1, n2));
        }

        public static double Addition (double num1, double num2);

        }
    }
}
