using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class OperationPerformer : IOperationPerformer
    {
        public double CalcBracketLessExpression(string expressionBracketsLess)
        {
            return OperationDefiner.Operations[0].Item4(expressionBracketsLess);
        }
    }
}
