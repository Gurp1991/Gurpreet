using System;

namespace conditional
{
    class practise
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            
            switch (a)
            {
                case 1:
                        Console.WriteLine("my name is gurpreet");
                break;
                case 2:
                        Console.WriteLine(" i love coffe");
                break;
                case 3:
                    Console.WriteLine("i love my family");
                    break;

                default:
                    Console.WriteLine("unknown number");
                break;
            }

        }
    }
}
