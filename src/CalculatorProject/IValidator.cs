using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    interface IValidator
    {
        void BracketsQuantityChecker(string expression);
    }
}
