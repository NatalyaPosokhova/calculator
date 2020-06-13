using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorProject
{
    public static class OperationsDefiner
    {
        static string number = @"(\d+\.\d+|\d+,\d+|\d+)";
        static string sign = @"(\+|\-)";
        static string numPattern = $"({sign}?{number})";

        public static List<IOperation> Operations = new List<IOperation>
        {
            new Operation (
                $"{numPattern}\\+{numPattern}",
                (opExpression) =>
                {
                    List<double> numbersList = GetNumbers(opExpression, "\\+");
                    return numbersList.Sum();
                },
                1),
            new Operation (
                $"{numPattern}\\-{numPattern}",
                (opExpression) =>
                {
                    List<double> numbersList = GetNumbers(opExpression, "\\-");
                    return numbersList[0] - numbersList[1];
                },
                1),
            new Operation (
                $"{numPattern}\\*{numPattern}",
                (opExpression) =>
                {
                    List<double> numbersList = GetNumbers(opExpression, "\\*");
                    return numbersList[0] * numbersList[1];
                },
                3),
            new Operation (
                $"{numPattern}\\/{numPattern}",
                (opExpression) =>
                {
                    List<double> numbersList = GetNumbers(opExpression, "\\/");
                    if(numbersList[1] == 0)
                    throw new DivideByZeroException();
                    return numbersList[0] / numbersList[1];
                },
                3)
         };

        private static List<double> GetNumbers(string opExpression, string operation)
        {
            if (!Regex.IsMatch(opExpression, $"{numPattern}{operation}{numPattern}"))
            {
                throw new Exception(); // TODO
            }

            return new List<double>
            {
                Convert.ToDouble(Regex.Matches(opExpression, $"{numPattern}{operation}{numPattern}")[0].Groups[1].Value),
                Convert.ToDouble(Regex.Matches(opExpression, $"{numPattern}{operation}{numPattern}")[0].Groups[4].Value)
            };
        }
    }
}