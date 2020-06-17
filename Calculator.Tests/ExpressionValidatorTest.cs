using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
{
    [TestClass]
    public class ExpressionValidatorTest
    {
        [TestMethod]
        public void UnitTestDifferentBracketsQuantityException()
        {
            // arrange
            var expression = "(7+8*(9-5)))";
            var validator = new ExpressionValidator();

            // act
            var actualResult = validator.Validate(expression);

            // assert
            Assert.AreEqual(validator.ErrorBracketsQuantity, actualResult);
        }

        [TestMethod]
        public void UnitTestExceededSymbolsException()
        {
            // arrange
            var expression = "(7+8*&(9-5))?";
            var validator = new ExpressionValidator();

            // act
            var actualResult = validator.Validate(expression);

            // assert
            Assert.AreEqual(validator.ErrorExceededSymbols, actualResult);
        }

        [TestMethod]
        public void UnitTestEmptyExpressionException()
        {
            // arrange
            var expression = "";
            var validator = new ExpressionValidator();

            // act
            var actualResult = validator.Validate(expression);

            // assert
            Assert.AreEqual(validator.ErrorEmpty, actualResult);
        }

        [TestMethod]
        public void UnitTestOverflowException()
        {
            // arrange
            Random rand = new Random();
            string[] operators = { "+", "-", "*", "/" };

            var expression = "";

            for (int i = 0; i < 501; i++)
            {
                string randomOperator = operators[rand.Next(operators.Length)];
                var randomNumber = rand.Next(-1000, 1000);

                expression += $"{randomNumber.ToString()}{randomOperator}-1";
            }

            var validator = new ExpressionValidator();

            // act
            var actualResult = validator.Validate(expression);

            // assert
            Assert.AreEqual(validator.ErrorTooLong, actualResult);
        }
    }
}
