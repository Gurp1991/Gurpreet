using System;

namespace Assignment_1_8040


{
    class TestTriangleSolver
    {
        static void Main(string[] args)
        {

        restartProgram:
            Console.Clear();
            Console.WriteLine("\n 1. Enter triangle dimension");
            Console.WriteLine("\n 2. Exit");
            Console.WriteLine(" Please Enter your choice number");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Please Enter three sides for triangle");
                    int x1 = int.Parse(Console.ReadLine());
                    int x2 = int.Parse(Console.ReadLine());
                    int x3 = int.Parse(Console.ReadLine());
                    
                    //Get output from method that validate the form is trinagle or not.
                    var outPut = TriangleSolver.Analyze(x1, x2, x3);

                    switch (outPut)
                    {
                        // verify  the output in switch statement for show user to diffrent type of trinagle.
                        case "Equilateral":
                            Console.WriteLine("This points makes a trinagle that is Equilateral ");
                            break;
                        case "Isosceles":
                            Console.WriteLine("This points makes a trinagle that is  Isosceles ");
                            break;
                        case "Scalene":
                            Console.WriteLine("This points makes a trinagle that is  Scalene ");
                            break;
                        default:
                            // In default case print the form is not Trinagle.
                            Console.WriteLine(outPut);
                            break;
                    }

                    break;
                case 2:
                    Environment.ExitCode = 0;
                    Environment.Exit(0);
                    break;

                default:
                    goto restartProgram; // This goto statement is used to restart program in case user enter invalid input.
            }

        }
    }
}