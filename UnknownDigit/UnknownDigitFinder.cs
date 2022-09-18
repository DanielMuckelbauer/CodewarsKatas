using System.Collections.Generic;
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
            Operand1UnknownIndices = GetQuestionMarkIndices(parts[0]),
            Operator = op,
            Operand2 = parts[1],
            Operand2UnknownIndices = GetQuestionMarkIndices(parts[1]),
            Result = parts[2],
            ResultUnknownIndices = GetQuestionMarkIndices(parts[2])
        };
    }

    private static IEnumerable<int> GetQuestionMarkIndices(string operand)
    {
        var index = 0;
        var list = new List<int>();
        while (index != -1)
        {
            index = operand.IndexOf('?', index + 1);
            if (index >= 0)
            {
                list.Add(index);
            }
        }
        return list;
    }
}