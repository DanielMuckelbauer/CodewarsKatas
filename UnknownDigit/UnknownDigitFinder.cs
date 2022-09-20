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
        return -1;
    }
}