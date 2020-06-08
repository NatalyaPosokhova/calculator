using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    interface IValidator
    {
        void BracketsQuantityChecker(string expression);

        void ExceededSymbolsChecker(string expression);

        void EmptyExpressionChecker(string expression);

        void OverflowChecker(string expression);
    }
}
