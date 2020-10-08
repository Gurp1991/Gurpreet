using System;


namespace ConsoleApp6GFG
{


    class Program
    {
        public static void Main()
        {
            int a = 7, b = 10, c = 5;

            // function calling and print output 
            if ((Class1.Analyze(a, b, c)) == 1)
                Console.Write(" this is a triagle ");
            else
                Console.Write("Invalid");

        }
    }
}