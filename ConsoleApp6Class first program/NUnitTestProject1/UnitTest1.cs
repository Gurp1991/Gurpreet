using NUnit.Framework;
using ConsoleApp6Class_first_program;

namespace NUnitTestProject1
{
    public class Tests
    {
        private Person pi;
        [SetUp]
        public void Setup()
        {
            pi = new Person();
        }

        [Test]
        public void Test1_Person1()
        {

            int side1 = 10;
            int side2 = 10;
            int side3 = 10;

            string expected_result = (first = 10 second = 10Third = 10);
            return actual_result = pi.Person1();
            Assert.AreEqual(expected_result, actual_result);


            Assert.Pass();
        }
    }
}