using NUnit.Framework;
using Assignment1_8040;

namespace NUnitTest_TriangleSolver
{
    [TestFixture]
    public class TriangleSolverTests
    {

        [SetUp]
        public void Setup()
        {

        }
        // to check whether these points forms a "Equilateral" triangle
        [Test]
        public void Test1_analyze_PointsMakesEquilateralTriangle()
        {
            //Act
            int x1 = 4;
            int x2 = 4;
            int x3 = 4;

            //Arrange

            string expected_result = "Equilateral";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //to check whether these points forms a "Isosceles" triangle
        [Test]
        public void Test2_analyze_PointsMakesIsoscelesTriangle()
        {
            //Act
            int x1 = 4;
            int x2 = 4;
            int x3 = 6;

            //Arrange

            string expected_result = "Isosceles";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //To check whether these points forms a "Scalene" triangle
        [Test]
        public void Test3_analyze_PointsMakesScaleneTriangle()
        {
            //Act
            int x1 = 7;
            int x2 = 4;
            int x3 = 6;

            //Arrange

            string expected_result = "Scalene";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //To check whether thses points forms a triangle or not
        [Test]
        public void Test4_analyze_PonitsFormsTriangle()
        {
            //Act
            int x1 = 1;
            int x2 = 4;
            int x3 = 3;

            //Arrange

            string expected_result = "These points  not form a triangle";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //To chcek whteher -ve number makes a triangle
        [Test]
        public void Test5_analyze_NegativeNumberMakesTriangle()
        {
            //Act
            int x1 = -1;
            int x2 = -4;
            int x3 = 3;

            //Arrange

            string expected_result = "These points  not form a triangle";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //To check whether expected  result is not same as actuall  result after execution (to chcek "AreNotEqual" method result correct if both are not equal object)
        [Test]
        public void Test6_analyze_ExpectedResultNotMatch()
        {
            //Act
            int x1 = -1;
            int x2 = -4;
            int x3 = 3;

            //Arrange

            string expected_result = "xxxxxxxxxxxx";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreNotEqual(expected_result, actual_result);
        }

        //To chcek whther these points form a triangle or not if enter all 0
        [Test]
        public void Test7_analyze_AllZeroPointsMakesTriangle()
        {
            //Act
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;

            //Arrange

            string expected_result = "These points  not form a triangle";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
        //To check whether thses points form a triangle just doing negative testing to check the boundry coverage of code
        [Test]
        public void Test8_analyze_NegativeTesting()
        {
            //Act
            int x1 = 50;
            int x2 = 10;
            int x3 = 5;

            //Arrange

            string expected_result = "These points  not form a triangle";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);
            //Assert
            Assert.AreEqual(expected_result, actual_result);
        }
    }
}