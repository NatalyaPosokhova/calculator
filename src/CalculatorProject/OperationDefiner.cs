using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class OperationDefiner : IOperationDefiner
    {

        static string number = @"(\d+\.\d+|\d+,\d+|\d+)";
        static string sign = @"(\+|\-)";
        static string numPattern = $"({sign}?{number})";


        // Item1 = operation, Item2 = priority, Item3 = pattern, Item4 = calculationResult
        //public static List<Tuple<string, int, string, Func<string, double>>> Operations =
        // new List<Tuple<string, int, string, Func<string, double>>>
        // {
        //        new Tuple<string, int, string, Func<string, double>>(
        //            "+",
        //            1,
        //            $"{numPattern}\\+{numPattern}",
        //            (opExpression) =>
        //            {
        //                List<double> numbersList = GetNumbers(opExpression, "\\+");
        //                return numbersList.Sum();
        //            }), 
        //         new Tuple<string, int, string, Func<string, double>>(
        //            "-",
        //            1,
        //            $"{numPattern}\\-{numPattern}",
        //            (opExpression) => 
        //            {
        //                List<double> numbersList = GetNumbers(opExpression, "\\-");
        //                return numbersList[0] - numbersList[1];
        //            }), 
        //         new Tuple<string, int, string, Func<string, double>>(
        //            "*",
        //            3,
        //            $"{numPattern}\\*{numPattern}",
        //            (opExpression) => 
        //            {
        //                List<double> numbersList = GetNumbers(opExpression, "\\*");
        //                return numbersList[0] * numbersList[1];
        //            }),
        //         new Tuple<string, int, string, Func<string, double>>(
        //            "/",
        //            3,
        //            $"{numPattern}\\/{numPattern}",
        //            (opExpression) => 
        //            {
        //                List<double> numbersList = GetNumbers(opExpression, "\\/");
        //                if(numbersList[1] == 0)
        //                throw new DivideByZeroException();
        //                return numbersList[0] / numbersList[1];
        //            }) 
                 
        // };

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
