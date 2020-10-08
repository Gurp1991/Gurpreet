using System;

namespace ConsoleApp6newswitch_case


{
    class practise
    {
        static void Main(string[] args)
        {

            
             Console.WriteLine("\n 1. Enter triangle dimension");
            Console.WriteLine("\n 2. Exit");
            Console.WriteLine(" Please Enter your choice number");
            int a = int.Parse(Console.ReadLine());
          
            switch (a)
            {
                case 1:
                    Console.WriteLine("Please Enter three integers");
                    int x1 = int.Parse(Console.ReadLine());
                    int x2 = int.Parse(Console.ReadLine());
                    int x3 = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("\n Do you want to exit ");
                   
                    break;
             default:
                    Console.WriteLine("unknown number please enter valid number");
                    break;
            }
            
        }
    }
}
