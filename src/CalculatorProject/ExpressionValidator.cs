using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorProject
{
    public class ExpressionValidator : IExpressionValidator
    {
        public readonly string ErrorBracketsQuantity = "Opened and Closed brackets' quantity is not equal.";
        public readonly string ErrorExceededSymbols = "Entered expression contains exceeded symbol(s).";
        public readonly string ErrorEmpty = "Entered expression is empty.";
        public readonly string ErrorTooLong = "Entered expression is too long.";

        public string Validate(string expression)
        {
            if (expression.Where(x => x == '(').Count() != expression.Where(x => x == ')').Count())
            {
                return ErrorBracketsQuantity;
            }

            Regex regex = new Regex("([А-Яа-я]|@|\"|\'|:|#|~|&|\\?)");
            if (expression.Any(el => regex.IsMatch(el.ToString())))
            {
                return ErrorExceededSymbols;
            }

            if (String.IsNullOrEmpty(expression))
            {
                return ErrorEmpty;
            }

            if (expression.Length > 1000)
            {
                return ErrorTooLong;
            }

            return null;
        }
    }
}