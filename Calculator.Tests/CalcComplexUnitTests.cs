using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTests
{
    [TestClass]
    public class CalcComplexUnitTests
    {
        [TestMethod]
        public void UnitTestWithAllOperatorsReturns45_0()
        {
            // arrange
            var expression = "42+5.2-2*5.5/5";

            var corrector = new CalculatorProject.ExpressionCorrector();
            expression = corrector.Correct(expression);

            var calculator = new CalculatorProject.Calculator(
                new Parser(), 
                new OperationPerformer());

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.AreEqual(45.0, actualResult);
        }

        [TestMethod]
        public void UnitTestWithBracketsReturnsMin1_4()
        {
            // arrange
            var expression = "8.4+(6-7.8)-(9*(7-6)-1)";

            var corrector = new CalculatorProject.ExpressionCorrector();
            expression = corrector.Correct(expression);

            var calculator = new CalculatorProject.Calculator(
                new Parser(),
                new OperationPerformer());

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.AreEqual(-1.4, actualResult);
        }
    }
}
