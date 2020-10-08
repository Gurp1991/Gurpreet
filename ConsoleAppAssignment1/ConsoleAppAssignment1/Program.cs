using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace ConsoleAppAssignment1
{
    class ProgramRegions

    {
        static void Main(string[] args)
        {
            // enter how many times users insert the points
            Console.WriteLine("Enter the value for num");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine(" \nPlease enter the Points for x and y\n");
                //Points belong to X - axis

               double x = double.Parse(Console.ReadLine());

                // find power using Math.Pow 
                //(x-2) is Base and 2 is power
                double pow_x = Math.Pow(x - 2, 2);

                //Points belong to y- axis
                double y = double.Parse(Console.ReadLine());

                //(y-2) is Base and 2 is power
                double pow_y = Math.Pow(y - 2, 2);
                //Display points on the console screen

                Console.WriteLine("The points which user inserted is ({0}, {1}):", x, y);
                //region 1 condition
                //((x-2, 2) + (y-2, 2)<=1 and (x + y) >3)

                if ((pow_x + pow_y <= 1) && (x + y) > 3)
                {
                    Console.WriteLine("\nThese points belongs to Region 1 : ({0}, {1}) ", x, y);
                }
                //region 2 condition
                else if ((pow_x + pow_y <= 1) && (x + y) <= 3)
                {
                    Console.WriteLine("\nThese points belongs to Region 2 " +
                        ": ({0}, {1}) ", x, y);
                }
                //region 4 condition
                else if ((pow_x + pow_y > 1) && (x + y) > 3)
                {
                    Console.WriteLine("\nThese points belongs to Region 4 : ({0}, {1}) ", x, y);
                }
                else
                {
                    Console.WriteLine("\nThese points belongs to Region 3 : ({0}, {1}) ", x, y);
                }
                num--;

            }

        }

    }
}