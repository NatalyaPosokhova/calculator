using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");

            var expression = Console.ReadLine();

            var calculator = new Calculator();

            var result = calculator.Compute(expression);

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }
    }
}
