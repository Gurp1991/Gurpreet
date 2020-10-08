using System;
using System.Transactions;

namespace comparison_operator
{
    class Comparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number");
            Console.WriteLine("enter first number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int d = int.Parse(Console.ReadLine());
            if (c == d)
            {
                Console.WriteLine("{0} {1} both are equal", c, d);
            }
            else
            {
                if(c > d)
                
                {
                    Console.WriteLine("{0} is greater than {1}", c, d);
               }
                else
                {
                    Console.WriteLine("{0} is less than {1}", c, d);
                }
            }
/*
            Console.WriteLine(w >= 700);
            int a = 20;
            int b = 10;
            bool condtion = (a < b) && (a + b < a * b);
            Console.WriteLine(condtion);

            Console.WriteLine("Hello World!");*/
        }
    }
}
