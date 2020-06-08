using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Validator : IValidator
    {
        public void BracketsQuantityChecker(string expression)
        {
            if (expression.Where(x => x == '(').Count() != expression.Where(x => x == ')').Count())
            {
                throw new Exception("Opened and Closed brackets' quantity is not equal.");
            }
        }
    }
}
