using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnknownDigit;

public static class ExpressionParser
{
    public static Expression Parse(string expression)
    {
        var regex = new Regex(@"(-{0,1}[?|\d]*)([-|*|+|/])(-{0,1}[?|\d]*)=(-{0,1}[?|\d]*)");
        var capturingGroups = regex.Match(expression).Groups;
        return new()
        {
            Operand1 = new(capturingGroups[1].Value),
            Operand2 = new(capturingGroups[3].Value),
            Result = new(capturingGroups[4].Value),
            Operator = capturingGroups[2].Value,
            IsZeroInvalid = expression.Contains("??"),
            IncludedNumbers = GetIncludedNumbers(expression)
        };
    }

    private static IEnumerable<int> GetIncludedNumbers(string expression)
        => expression
            .ToCharArray()
            .Where(character => int.TryParse(character.ToString(), out _))
            .Select(character => int.Parse(character.ToString()));
}