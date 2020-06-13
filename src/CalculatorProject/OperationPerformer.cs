using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorProject
{
    public class OperationPerformer : IOperationPerformer
    {
        public string CalcBracketLessExpression(string expressionBracketsLess)
        {
            var orderedOperationsList = OperationsDefiner.Operations.OrderBy(op => op.Priority).Reverse().ToList();

            for (int op = 0; op < orderedOperationsList.Count; op++)
            {
                while (Regex.IsMatch(expressionBracketsLess, orderedOperationsList[op].RegexPattern)) 
                {
                    var opExpression = Regex.Match(expressionBracketsLess, orderedOperationsList[op].RegexPattern).Value;
                    var opResult =
                        (orderedOperationsList[op].Calculate(opExpression) >= 0 ? "+" : "") +
                        orderedOperationsList[op].Calculate(opExpression).ToString();

                    var regex = new Regex(orderedOperationsList[op].RegexPattern);
                    expressionBracketsLess = regex.Replace(expressionBracketsLess, opResult, 1);
                }
            }

            return expressionBracketsLess;
        }
    }
}