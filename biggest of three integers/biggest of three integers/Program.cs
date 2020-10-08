using System;

namespace biggest_of_three_integers
{
    class biggest3

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number");
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            if (one > two)
            {
                if (one > three)
                {

                    Console.WriteLine("number {0} is greater than among three integers",one,three);
                }
                else
                {
                    Console.WriteLine("number {2} is greater than among three integers",three,one);
                }
            }
            else if (two > three)
            {
                Console.WriteLine("number {1} is greater than among three intergers",two);
            }
            else
            {
                Console.WriteLine("number {2} is greater than among three integers",three);
            }
            Console.ReadLine();
            }
        }
    }

