using NUnit.Framework;
using Assignment_1_8040;
using System;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace NUnitTestTriangleClass_testing
{
    [TestFixture]
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
           
        }
        // to check whether these points forms a "Equilateral" triangle
        [Test]
        public void Test1_analyze()
        {
            //Act
            int x1 = 4;
            int x2 = 4;
            int x3 = 4;

            //Arrange

            string expected_result = "Equilateral";
            string actual_result = TriangleSolver.Analyze(x1, x2, x3);

            Assert.AreEqual(expected_result, actual_result);
        }
        //to check whether these points forms a "Isosceles" triangle
        [Test]
        public void Test2_analyze()
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
        //to check whether these points forms a "Scalene" triangle
        [Test]
        public void Test3_analyze()
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
        //to check whether thses points forms a triangle or not
        [Test]
        public void Test4_analyze()
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
        //to chcek whteher -ve number makes a triangle
        [Test]
        public void Test5_analyze()
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
        //to check whether expected  result is not same as actuall  result after execution (to chcek "AreNotEqual" method result correct if both are not equal object)
        [Test]
        public void Test6_analyze()
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

        //to chcek whther these points form a triangle or not if enter all 0
        [Test]
        public void Test7_analyze()
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
        //to check whether thses points form a triangle just doing negative testing to check the boundry of the triangle
        [Test]
        public void Test8_analyze()
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