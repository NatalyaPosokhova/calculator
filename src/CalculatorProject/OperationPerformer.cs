using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class OperationPerformer : IOperationPerformer
    {
        public double CalcBracketLessExpression(string expressionBracketsLess)
        {
            double result = 0.0;

            for (int op = 0; op < OperationDefiner.Operations.Count; op++)
            {
                if (Regex.IsMatch(expressionBracketsLess, OperationDefiner.Operations[op].Item3))
                {
                    result = OperationDefiner.Operations[op].Item4(expressionBracketsLess);
                }
            }
            return result;
        }
    }
}
