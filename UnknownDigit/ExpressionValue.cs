using System.Collections.Generic;

namespace UnknownDigit;

public class ExpressionValue
{
    public string Amount { get; set; }
    public int Factor { get; set; }
    public IEnumerable<int> UnknownDigitsOfAmount { get; set; }

    public ExpressionValue(string capturedGroup)
    {
        Amount = capturedGroup.TrimStart('-');
        Factor = capturedGroup.StartsWith('-') ? -1 : 1;
        UnknownDigitsOfAmount = capturedGroup.LocateCharacterIndices('?');
    }
}