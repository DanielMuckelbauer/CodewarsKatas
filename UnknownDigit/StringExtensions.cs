using System.Collections.Generic;
using System.Linq;

namespace UnknownDigit;

public static class StringExtensions
{
    public static IEnumerable<int> LocateCharacterIndices(this string theString, char theChar)
        => theString
            .ToCharArray()
            .Select((character, i) => (character, i))
            .Aggregate(new List<int>(), (indices, tuple) => tuple.character == theChar
                ? indices.Concat(new[] { tuple.i }).ToList()
                : indices);
}