using NUnit.Framework;
using AgaintestingTriangleclass;

namespace NUnitTestProjectTriangleSolver_AnalyzeMethod
{
    public class TestsTriangleSolver
    {
        private TriangleSolver test;
        
        [SetUp]
        public void Setup()
        {
            test = new TriangleSolver();
        }

        [Test]
        /* public void Test1_analyze()
        {
            //Act
            int x1 = 4;
            int x2 = 4;
            int x3 = 4;
           
            //arrange

            string expected_result = "Equilateral";
            string actual_result = test.Analyze(x1, x2, x3);

            Assert.AreEqual(expected_result, actual_result);
        }*/


        public void Test2_analyze()
        {
            //Act
            int x1 = 4;
            int x2 = 4;
            int x3 = 3;

            //arrange

            string expected_result = "Isosceles";
            string actual_result = test.Analyze(x1, x2, x3);

            Assert.AreEqual(expected_result, actual_result);
        }
    }
}