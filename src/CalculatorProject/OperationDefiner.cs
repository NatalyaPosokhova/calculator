using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class OperationDefiner : IOperationDefiner
    {
        static string number = @"(\d+\.\d+)|(\d+\,\d+)|(\d+)";
        
        // operation, priority, pattern, calculationesult
        public static List<Tuple<string, int, string, Func<string, double>>> Operations =
         new List<Tuple<string, int, string, Func<string, double>>>
         {
                new Tuple<string, int, string, Func<string, double>>(
                    "+",
                    3,
                    $"{number}\\+{number}",
                    (expression) => { return 6.0; }) // TODO
         };
    }
}
