using System;

namespace CalculatorProject
{
    public interface IOperation
    {
        string RegexPattern { get; set; }

        Func<string, double> Calculate { get; set; }

        int Priority { get; set; }
    }
}