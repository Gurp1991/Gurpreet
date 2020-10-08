using System;

namespace ConsoleApp4
{
    class GFG
    {
        static public void Main(string[] args)
        {
            Console.WriteLine(" please enter the value for x and y");
            int x = int.Parse(Console.ReadLine());
            double pow_x = Math.Pow(x - 2, 2);

            //Console.WriteLine(" please enter the value for y");

            int y = int.Parse(Console.ReadLine());
            double pow_y = Math.Pow(y - 2, 2);

            Console.WriteLine("Result from given equation {0}",pow_x + pow_y);
            //bool Region1 = (pow_x + pow_y <= 1) && (x + y) > 3;
            //Console.WriteLine(Region1);
           /* bool Region2 = (pow_x + pow_y <= 1) && (x + y) <= 3;
            Console.WriteLine(Region2);
            bool Region3 = (pow_x + pow_y > 1) && (x + y) <= 3;
            Console.WriteLine(Region3);
            bool Region4 = (pow_x + pow_y > 1) && (x + y) > 3;
            Console.WriteLine(Region4);
           */
            //if((pow_x + pow_y) && (int x + int y) <= 1)
            if ((pow_x + pow_y <= 1) && (x + y) > 3)
            {
                if ((pow_x + pow_y <= 1) && (x + y) <= 3)
                {
                    Console.WriteLine("The number of the points in region 2 is: ({0}, {1}) ", x, y);
                }
                else
                {
                    Console.WriteLine("The number of the points in region 1 is: ({0}, {1}) ", x, y);

                }
            }
            else
            {
                if ((pow_x + pow_y > 1) && (x + y) <= 3)
                {
                    Console.WriteLine("The number of the points in region 4 is: ({0}, {1}) ", x, y);

                }
                else
                {
                    Console.WriteLine("The number of the points in region 3 is: ({0}, {1}) ", x , y);

                }

            }
          

    



        }
                                   
            
        
    }
}