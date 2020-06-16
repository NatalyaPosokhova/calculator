using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using Moq;

namespace CalcTests
{
    [TestClass]
    public class CalculatorTest
    {
        private delegate string CallbackReturns(string s, out int i);

        [TestMethod]
        public void ComputeTest()
        {
            // arrange
            var expression = "(4444+88)-3+8*5-2";

            Mock<IParser> parser = new Mock<IParser>();
            parser.Setup(m => m.FindDeeperBracketContent(It.IsAny<string>(), out It.Ref<int>.IsAny))
                .Returns(new CallbackReturns((string s, out int i) => { i = 0; return "2+1"; }));

            Mock<IOperationPerformer> performer = new Mock<IOperationPerformer>();
            performer.Setup(m => m.CalcBracketLessExpression(It.IsAny<string>())).Returns("3");

            var calculator = new Calculator(parser.Object, performer.Object);

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.AreEqual(3.0, actualResult);
        }
    }
}
