using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

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

        [TestMethod]
        public void UnitTestDifferentBracketsQuantityException()
        {
            // arrange
            var expression = "(7+8*(9-5)))";
            var validator = new ExpressionValidator();
       
            // act
            var actualResult = validator.Validate(expression);

            // assert
            Assert.AreEqual(actualResult, validator.ErrorBracketsQuantity);
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
            Assert.AreEqual(actualResult, validator.ErrorExceededSymbols);
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
            Assert.AreEqual(actualResult, validator.ErrorEmpty);
        }

        [TestMethod]
        public void UnitTestOverflowException()
        {
            // arrange
            Random rand = new Random();
            string[] operators = { "+", "-", "*", "/"};
            
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
            Assert.AreEqual(actualResult, validator.ErrorTooLong);
        }
    }
}