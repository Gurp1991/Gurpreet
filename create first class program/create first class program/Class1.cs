using System;
using System.Collections.Generic;
using System.Text;

namespace create_first_class_program
{
    class Class1
    {
        {
            double x;
            double y;
        }
        //constructor with two parameter
        public Class1(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public String PrintClass1()
        {
            return " add (x=y:)(+this.x + this.y )";
        }

        class Program
        {
            static void Main(string[] args)
            {
            Class1 p = new Class1(5, 6);
                Console.WriteLine($"result is {p.PrintClass1()}");
            }
        }
}
