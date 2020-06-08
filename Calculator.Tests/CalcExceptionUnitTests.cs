using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalcExceptionUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void UnitTestChecksDivideByZeroException()
        {
            // arrange
            var expression = "6.7/0.0";
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(DivideByZeroException));
        }
    }
}
