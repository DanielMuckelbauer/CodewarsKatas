using FluentAssertions;

namespace UnknownDigit.Tests;

public class UnknownDigitsFinderTests
{
    [Theory]
    [InlineData("123*45?=5?088", 6)]
    [InlineData("19--45=5?", -1)]
    public void Finds_Unknown_Digits(string input, int solution)
        => UnknownDigitFinder.SolveExpression(input).Should().Be(solution);
}