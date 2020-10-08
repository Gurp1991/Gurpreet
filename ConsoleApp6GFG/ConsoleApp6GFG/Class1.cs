using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6GFG
{
    public static class Class1
    {
        public static int Analyze(int a, int b,
                                    int c)
        {

            // check condition 
            if (a + b <= c || a + c <= b ||
                                b + c <= a)
                return 0;
            else
                return 1;
        }
    }
}
