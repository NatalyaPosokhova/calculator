using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public void ExceededSymbolsChecker(string expression)
        {
            Regex regex = new Regex("([А-Яа-я]|@|\"|\'|#|~|&|\\?)");
            if (expression.Any(el => regex.IsMatch(el.ToString())))
            {
                throw new Exception("Entered expression contains exceeded symbols.");
            }
        }
    }
}
