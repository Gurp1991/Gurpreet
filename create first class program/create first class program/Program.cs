using System;

namespace create_first_class_program
{
    class Point
    {
        double x;
        double y;
    }
    //constructor with two parameter
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public String PrintPoint()
    {
        return " add (x=y:)(+this.x + this.y )";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(5, 6);
            Console.WriteLine($"result is {p.PrintPoint()}");
        }
    }
}
