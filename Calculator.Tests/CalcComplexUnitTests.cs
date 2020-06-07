using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalcComplexUnitTests
    {
        [TestMethod]
        public void UnitTestWithAllOperatorsReturns45_0()
        {
            // arrange
            var expression = "42+5.2-2*5.5/5";
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.AreEqual(45.0, actualResult);
        }
    }
}
