using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        public double Compute(string expression)
        {
            expression = expression.Replace(" ", String.Empty).Replace(".", ",");

            Parser parser = new Parser();
            OperationPerformer performer = new OperationPerformer();

            while (expression.Contains(")"))
            {
                int startIndex;
                var deeperBracketContent = parser.FindDeeperBracketContent(expression, out startIndex);
                var localResult = performer.CalcBracketLessExpression(deeperBracketContent);

                var sb = new StringBuilder(expression);
                sb.Remove(startIndex, deeperBracketContent.Length + 2);
                sb.Insert(startIndex, localResult);
                expression = sb.ToString();
            }

            return Convert.ToDouble(performer.CalcBracketLessExpression(expression));
        }
    }
}
