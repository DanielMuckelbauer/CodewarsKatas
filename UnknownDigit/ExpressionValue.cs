using System.Collections.Generic;

namespace UnknownDigit;

public class ExpressionValue
{
    private string Amount { get; set; }
    private int Factor { get; set; }
    private IEnumerable<int> UnknownDigitsOfAmount { get; set; }

    public ExpressionValue(string capturedGroup)
    {
        Amount = capturedGroup.TrimStart('-');
        Factor = capturedGroup.StartsWith('-') ? -1 : 1;
        UnknownDigitsOfAmount = capturedGroup.LocateCharacterIndices('?');
    }

    public int SubstituteUnknown(int i)
    {
        var replacedString = Amount.Replace("?", i.ToString());
        return int.Parse(replacedString) * Factor;
    }
}