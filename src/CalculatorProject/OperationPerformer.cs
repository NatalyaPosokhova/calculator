using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class OperationPerformer : IOperationPerformer
    {
        public string CalcBracketLessExpression(string expressionBracketsLess)
        {
            var orderedOperationsList = OperationDefiner.Operations.OrderBy(op => op.Item2).Reverse().ToList();

            for (int op = 0; op < orderedOperationsList.Count; op++)
            {
                while (Regex.IsMatch(expressionBracketsLess, orderedOperationsList[op].Item3)) 
                {
                    var opExpression = Regex.Match(expressionBracketsLess, orderedOperationsList[op].Item3).Value;
                    var opResult =
                        (orderedOperationsList[op].Item4(opExpression) >= 0 ? "+" : "") +
                        orderedOperationsList[op].Item4(opExpression).ToString();

                    var regex = new Regex(orderedOperationsList[op].Item3);
                    expressionBracketsLess = regex.Replace(expressionBracketsLess, opResult, 1);
                }
            }

            return expressionBracketsLess;
        }
    }
}
