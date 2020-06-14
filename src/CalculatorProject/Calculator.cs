using System;
using System.Text;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        private readonly IParser parser;

        private readonly IOperationPerformer performer;

        public Calculator(IParser parser_, IOperationPerformer performer_)
        {
            this.parser = parser_;
            this.performer = performer_;
        }

        public double Compute(string expression)
        {
            while (expression.Contains(")"))
            {
                int startIndex;
                var deeperBracketContent = this.parser.FindDeeperBracketContent(expression, out startIndex);
                var localResult = this.performer.CalcBracketLessExpression(deeperBracketContent);

                var sb = new StringBuilder(expression);
                sb.Remove(startIndex, deeperBracketContent.Length + 2);
                sb.Insert(startIndex, localResult);
                expression = sb.ToString();
            }

            return Convert.ToDouble(performer.CalcBracketLessExpression(expression));
        }
    }
}