using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public interface IExpressionCorrector
    {
        string Correct(string expression);
    }
}
