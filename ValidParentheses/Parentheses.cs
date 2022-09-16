using System.Collections.Generic;
using System.Linq;

namespace ValidParentheses;

public static class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        var sequence = input
            .ToCharArray()
            .Where(character => character is '(' or ')');
        return CheckValidity(sequence);
    }

    private static bool CheckValidity(IEnumerable<char> sequence)
    {
        var openParenthesesCount = 0;
        foreach (var character in sequence)
        {
            switch (character)
            {
                case ')' when openParenthesesCount <= 0:
                    return false;
                case ')':
                    openParenthesesCount--;
                    break;
                case '(':
                    openParenthesesCount++;
                    break;
            }
        }

        return openParenthesesCount == 0;
    }
}