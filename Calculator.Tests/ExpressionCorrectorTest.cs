using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
{
    [TestClass]
    public class ExpressionCorrectorTest
    {
        [TestMethod]
        public void CorrectTestMethod()
        {
            // arrange
            var expression = "4 + 2 - 8.5 = ";
            var corrector = new ExpressionCorrector();

            // act
            var actualResult = corrector.Correct(expression);

            // assert
            Assert.AreEqual("4+2-8,5", actualResult);
        }
    }
}
