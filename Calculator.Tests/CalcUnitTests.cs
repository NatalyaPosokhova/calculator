using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
{
    [TestClass]
    public class CalcUnitTests
    {
        [TestMethod]
        public void UnitTestWithSumReturns6_0()
        {
            // arrange
            var expression = "4+2";
            var calculator = new Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.AreEqual(6.0, actualResult);
        }
    }
}
