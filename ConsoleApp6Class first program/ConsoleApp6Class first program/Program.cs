using System;

namespace ConsoleApp6Class_first_program
{
     public class Person
    {
        public int side1;
        public int side2;
        public int side3;
        
         
        public void Person1()
        {
            Console.WriteLine(" first=" + side1 + " second = " +  side2 +  "Third =" + side3);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.side1 = 10;
            p1.side2 = 10;
            p1.side3 = 10;

            p1.Person1();
        }
    }
}
