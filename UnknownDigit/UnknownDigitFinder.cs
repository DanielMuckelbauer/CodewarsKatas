using System.Text.RegularExpressions;

namespace UnknownDigit;

public static class UnknownDigitFinder
{
    public static int SolveExpression(string expression)
    {
        var parsedExpression = ParseExpression(expression);
        return SolveExpression(parsedExpression);
    }

    private static int SolveExpression(Expression expression)
    {
        return -1;
    }

    private static Expression ParseExpression(string expression)
    {
        var parts = expression.Split('*', '+', '-', '=');
        var op = Regex.Match(expression, @"[\+|-|\*|]").Value;
        return new()
        {
            Operand1 = parts[0],
            Operator = op,
            Operand2 = parts[1],
            Result = parts[2]
        };
    }
}