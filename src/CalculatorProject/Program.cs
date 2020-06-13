using System;

namespace CalculatorProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");
            var expression = Console.ReadLine();

            IExpressionValidator validator = new ExpressionValidator();
            var validationResult = validator.Validate(expression);
            if (validationResult != null)
            {
                Console.WriteLine(validationResult);
                Console.ReadKey();
                return;
            }

            var calculator = new Calculator();
            var result = calculator.Compute(expression);

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}