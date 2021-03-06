﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AgaintestingTriangleclass
{
    //public static class TriangleSolver
        public class TriangleSolver
    {
        public String Analyze(int x1, int x2, int x3)
        {

            //condtion check whether these points make triangles or not

            if (((x1 + x2) <= x3) || ((x1 + x3) <= x2) || ((x2 + x3) <= x1))

            {
                return "These points  not form a triangle";
            }
            else
            {
                //for checking the different types of triangles
                //if all sides are equal  then this triangle is Equilateral

                if (x1 == x2 && x2 == x3)
                    return "Equilateral";

                // if any two sides are equal then this triangle is Isosceles
                else if (x1 == x2 || x2 == x3)
                    return "Isosceles";
                //if any two sides are equal then this triangle is Scalene
                else
                    return "Scalene";
            }
        }
    }
}
