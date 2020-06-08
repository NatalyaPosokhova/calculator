using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Parser : IParser
    {
        public string FindDeeperBracketContent(string expression, out int index)
        {
            var index2 = expression.IndexOf(")");
            var beforeClosedBracket = expression.Substring(0, index2 + 1);
            var index1 = beforeClosedBracket.LastIndexOf("(");
            index = index1;
            return expression.Substring(index1 + 1, index2 - index1 - 1);
        }
    }
}
