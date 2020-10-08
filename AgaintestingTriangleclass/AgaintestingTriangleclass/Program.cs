using System;

namespace AgaintestingTriangleclass
{
    
    class practise1
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
                    Console.WriteLine("Please Enter three integers");
                    int x1 = int.Parse(Console.ReadLine());
                    int x2 = int.Parse(Console.ReadLine());
                    int x3 = int.Parse(Console.ReadLine());
                    TriangleSolver ts1;
                    ts1 = new TriangleSolver();
                    //Get output from method that validate the form is trinagle or not.
                    //var outPut = TriangleSolver.Analyze(x1, x2, x3);
                    var outPut = ts1.Analyze(x1, x2, x3);

                    switch (outPut)
                    {
                        // verify  the output n switch statement for show user to type of trinagle.
                        case "Equilateral":
                            Console.WriteLine("This poins makes a trinagle that is Equilateral ");
                            break;
                        case "Isosceles":
                            Console.WriteLine("This poins makes a trinagle that is  Isosceles ");
                            break;
                        case "Scalene":
                            Console.WriteLine("This poins makes a trinagle that is  Scalene ");
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
