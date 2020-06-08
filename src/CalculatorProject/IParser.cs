using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    interface IParser
    {
        string FindDeeperBracketContent(string expression, out int index);
    }
}
