using FluentAssertions;

namespace UnknownDigit.Tests;

public class QuestionMarkLocatorTests
{
    [Theory]
    [InlineData("354?12", new[]{3})]
    [InlineData("??", new[]{0, 1})]
    [InlineData("1?3?", new[]{1, 3})]
    public void Locates_QuestionMarks(string input, int[] indices)
        => input.LocateCharacterIndices('?').Should().BeEquivalentTo(indices);
}