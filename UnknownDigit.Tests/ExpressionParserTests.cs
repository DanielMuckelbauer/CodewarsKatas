using FluentAssertions;

namespace UnknownDigit.Tests;

public class ExpressionParserTests
{
    [Fact]
    public void Parses_Expression_With_Negative_Values()
    {
        const string expressionString = "-1--2?=-5?0";
        var expectedValue = new Expression
        {
            Operand1 = new("-1"),
            Operand2 = new("-2?"),
            Result = new("-5?0"),
            Operator = "-",
            IsZeroInvalid = false,
            IncludedNumbers = new[] { 1, 2, 5, 0 }
        };

        var result = ExpressionParser.Parse(expressionString);

        result.Should().BeEquivalentTo(expectedValue);
    }
}