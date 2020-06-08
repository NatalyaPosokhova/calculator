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

        [TestMethod]
        [ExpectedException(typeof(Exception), "Opened and Closed brackets' quantity is not equal.")]
        public void UnitTestDifferentBracketsQuantityException()
        {
            // arrange
            var expression = "(7+8*(9-5)))";
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(Exception));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Entered expression contains exceeded symbols.")]
        public void UnitTestExceededSymbolsException()
        {
            // arrange
            var expression = "(7+8*&(9-5))?";
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(Exception));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Entered expression is empty.")]
        public void UnitTestEmptyExpressionException()
        {
            // arrange
            var expression = "";
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(Exception));
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
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
          
            var calculator = new CalculatorProject.Calculator();

            // act
            var actualResult = calculator.Compute(expression);

            // assert
            Assert.IsInstanceOfType(actualResult, typeof(Exception));
        }

    }
}
