using System;

namespace ConsoleApp6Static_test_class
{
    public  class TriangleSolver
    {
        public static int side1;
        public static int side2;
        public static int side3;
        public static string Result;

        public static int Analyze()

        {
            Console.WriteLine("enter three valuse");
             side1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" enter first side1 {0}", side1);
            side2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(side2);
            side3 = int.Parse(Console.ReadLine());
            //Console.WriteLine(side3);
            //Result = Console.WriteLine(side1);
            return Result;

            


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TriangleSolver.Analyze();
            Console.ReadLine();

        }
    }
}
