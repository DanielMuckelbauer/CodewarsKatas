using System;

namespace UnknownDigit;

public static class UnknownDigitFinder
{
    public static int SolveExpression(string expression)
    {
        var parsedExpression = ExpressionParser.Parse(expression);
        return SolveExpression(parsedExpression);
    }

    private static int SolveExpression(Expression expression)
    {
        for (var i = 0; i < 10; i++)
        {
            var operand1 = expression.Operand1.SubstituteUnknown(i);
            var operand2 = expression.Operand2.SubstituteUnknown(i);
            var expectedResult = expression.Result.SubstituteUnknown(i);
            var calculatedResult = expression.Operator switch
            {
                "+" => operand1 + operand2,
                "-" => operand1 - operand2,
                "*" => operand1 * operand2,
                _ => throw new ArgumentOutOfRangeException()
            };
            if (calculatedResult == expectedResult)
            {
                return i;
            }
        }

        return -1;
    }
}