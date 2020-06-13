using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Operation : IOperation
    {
        public string RegexPattern { get; set; }

        public Func<string, double> Calculate { get; set; }

        public int Priority { get; set; }

        public Operation(string regexPattern, Func<string, double> calculate, int priority)
        {
            this.RegexPattern = regexPattern;
            this.Calculate = calculate;
            this.Priority = priority;
        }
    }
}
