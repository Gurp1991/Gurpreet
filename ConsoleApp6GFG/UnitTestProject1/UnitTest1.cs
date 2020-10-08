using System;
using NUnit.Framework;
using System.Runtime.Remoting.Messaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp6GFG

namespace UnitTestProject1
    
{
    [TestClass]
    public class UnitTest1
    {
        private Class1 c1;

    public void Setup()
        {
           c1 = new Class1();
        }

        [TestMethod]
        public void Test_Analyze1()
        {
            int a = 7;
            int b = 10;
            int c = 5;
            String expected_result = "this is a triagle";
            String actual_result = c1.Analyze(a, b, c);
            Assert.AreEqual(expected_result, actual_result);

        }
    }
}
