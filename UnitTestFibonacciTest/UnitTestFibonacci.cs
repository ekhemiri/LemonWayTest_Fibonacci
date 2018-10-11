using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciTest.Controllers;

namespace UnitTestFibonacciTest
{
    [TestClass]
    public class UnitTestFibonacci
    {

        [TestMethod]
        public void FibonacciValeurZero()
        {
            FibonacciHelper test = new FibonacciHelper();
            int valeur = test.Fibonacci(0);
            Assert.AreEqual(valeur, -1);
        }

        [TestMethod]
        public void FibonacciValeurCentUn()
        {
            FibonacciHelper test = new FibonacciHelper();
            int valeur = test.Fibonacci(101);
            Assert.AreEqual(valeur, -1);
        }

        [TestMethod]
        public void FibonacciValeurUn()
        {
            FibonacciHelper test = new FibonacciHelper();
            int valeur = test.Fibonacci(1);
            Assert.AreEqual(valeur, 1);
        }

        [TestMethod]
        public void FibonacciValeurDix()
        {
            FibonacciHelper test = new FibonacciHelper();
            int valeur = test.Fibonacci(10);
            Assert.AreEqual(valeur, 55);
        }
    }
}
