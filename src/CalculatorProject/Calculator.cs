using System;
using System.Text;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        public double Compute(string expression)
        {
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