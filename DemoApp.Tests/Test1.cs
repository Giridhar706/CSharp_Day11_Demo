using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoApp;

namespace DemoApp.Tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Multiply_Test()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(12, calc.Multiply(2, 6));
        }

        [TestMethod]
        public void Add_Test()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(8, calc.Add(5, 3));
        }

        [TestMethod]
        public void Subtract_Test()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(6, calc.Subtract(10, 4));
        }

        [TestMethod]
        public void Divide_Test()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(4, calc.Divide(8, 2));
        }

        [TestMethod]
        public void Divide_By_Zero_Test()
        {
            Calculator calc = new Calculator();

            try
            {
                calc.Divide(5, 0);
                Assert.Fail("Expected exception was not thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}