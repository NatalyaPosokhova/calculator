using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
{
    [TestClass]
    public class OperationPerformerTest
    {
        [TestMethod]
        public void CalcBracketLessExpressionTestMethod()
        {
            // arrange
            var expressionBracketsLess = "8/4+6-5-4";

            var performer = new OperationPerformer();

            // act
            var actualResult = performer.CalcBracketLessExpression(expressionBracketsLess);

            // assert
            Assert.AreEqual("-1", actualResult);
        }
    }
}
