using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
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

            var corrector = new ExpressionCorrector();
            expression = corrector.Correct(expression);

            var calculator = new Calculator(
                new Parser(),
                new OperationPerformer());

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(DivideByZeroException));
        }
    }
}