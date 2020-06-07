﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator : ICalculator
    {
        public double Compute(string expression)
        {
            var operation = new OperationPerformer();
            
            return operation.CalcBracketLessExpression(expression.Replace(" ", String.Empty)); 
        }
    }
}
