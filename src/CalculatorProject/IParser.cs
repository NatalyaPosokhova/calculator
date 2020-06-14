namespace CalculatorProject
{
    public interface IParser
    {
        string FindDeeperBracketContent(string expression, out int index);
    }
}