using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class ExpressionCorrector : IExpressionCorrector
    {
        public string Correct(string expression)
        {
            return expression
                .Replace(" ", String.Empty)
                .Replace(".", ",")
                .TrimEnd('=');
        }
    }
}
