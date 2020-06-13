namespace CalculatorProject
{
    interface IParser
    {
        string FindDeeperBracketContent(string expression, out int index);
    }
}