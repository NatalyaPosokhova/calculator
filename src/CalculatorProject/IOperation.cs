using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public interface IOperation
    {
        string RegexPattern { get; set; }

        Func<string, double> Calculate { get; set; }

        int Priority { get; set; }
    }
}
