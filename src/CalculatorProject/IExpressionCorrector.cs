using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    interface IExpressionCorrector
    {
        string Correct(string expression);
    }
}
