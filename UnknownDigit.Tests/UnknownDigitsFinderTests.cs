using FluentAssertions;

namespace UnknownDigit.Tests;

public class UnknownDigitsFinderTests
{
    [Theory]
    [InlineData("123*45?=5?088", 6)]
    [InlineData("19--45=5?", -1)]
    [InlineData("?*11=??", 2)]
    [InlineData("-?*11=?", 0)]
    [InlineData("-?*?=?", 0)]
    [InlineData("?*51=?", 0)]
    public void Finds_Unknown_Digits(string input, int solution)
        => UnknownDigitFinder.SolveExpression(input).Should().Be(solution);
}

// ? is always the same digit
// ? is never an already existing digit