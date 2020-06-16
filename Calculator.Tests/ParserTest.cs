using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;

namespace CalcTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void FindDeeperBracketContentTestMethod()
        {
            // arrange
            var expression = "876/(4.8-(2+1))";
            int index;

            var parser = new Parser();

            // act
            var actualResult = parser.FindDeeperBracketContent(expression, out index);

            // assert
            Assert.AreEqual("2+1", actualResult);
        }

        [TestMethod]
        public void FindDeeperBracketIndexTestMethod()
        {
            // arrange
            var expression = "876/(4.8-(2+1))";
        
            var parser = new Parser();

            // act
            int actualResult;
            parser.FindDeeperBracketContent(expression, out actualResult);

            // assert
            Assert.AreEqual(9, actualResult);
        }
    }
}
