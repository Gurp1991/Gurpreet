using System;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp4
{
    class GFG
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Enter the value for number");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine(" \nPlease enter the value for x and y\n");
                double x = double.Parse(Console.ReadLine());
                double pow_x = Math.Pow(x - 2, 2);
                double y = double.Parse(Console.ReadLine());
                double pow_y = Math.Pow(y - 2, 2);
                Console.WriteLine("({0}, {1})", x, y);
                if ((pow_x + pow_y <= 1) && (x + y) > 3)
                {
                    Console.WriteLine("\nThese points lies in Region 1 is: ({0}, {1}) ", x, y);
                }
                else if ((pow_x + pow_y <= 1) && (x + y) <= 3)
                {
                    Console.WriteLine("\nThe number of the points in region 2 is: ({0}, {1}) ", x, y);
                }

                else if ((pow_x + pow_y > 1) && (x + y) > 3)
                {
                    Console.WriteLine("\nThe number of the points in region 4 is: ({0}, {1}) ", x, y);
                }
                else
                {
                    Console.WriteLine("\nThe number of the points in region 3 is: ({0}, {1}) ", x, y);
                }
                num--;

            }
            
        }

    }
}