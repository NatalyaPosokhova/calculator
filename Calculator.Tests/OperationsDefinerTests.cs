using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System.Text.RegularExpressions;

namespace CalcTests
{
    [TestClass]
    public class OperationsDefinerTests
    {
        [TestMethod]
        public void OperationsListFuncSumTest()
        {
             // arrange
            var opExpression = "4+2";
           
            // act
            var actualResult = CalcWithAppropriateFunction(opExpression);

            // assert
            Assert.AreEqual(6.0, actualResult);
        }

        [TestMethod]
        public void OperationsListFuncSubtractionTest()
        {
            // arrange
            var opExpression = "4-5";

            // act
            var actualResult = CalcWithAppropriateFunction(opExpression);

            // assert
            Assert.AreEqual(-1, actualResult);
        }


        [TestMethod]
        public void OperationsListFuncMultiplicationTest()
        {
            // arrange
            var opExpression = "4*5";

            // act
            var actualResult = CalcWithAppropriateFunction(opExpression);

            // assert
            Assert.AreEqual(20.0, actualResult);
        }

        [TestMethod]
        public void OperationsListFuncDivisionTest()
        {
            // arrange
            var opExpression = "4/5";

            // act
            var actualResult = CalcWithAppropriateFunction(opExpression);

            // assert
            Assert.AreEqual(0.8, actualResult);
        }

        private double CalcWithAppropriateFunction(string opExpression)
        {
            return OperationsDefiner.Operations
                .Find(x => Regex.IsMatch(opExpression, x.RegexPattern))
                .Calculate(opExpression);
        }
    }
}
