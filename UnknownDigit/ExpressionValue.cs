namespace UnknownDigit;

public class ExpressionValue
{
    private string Amount { get; }
    private int Factor { get; }

    public ExpressionValue(string capturedGroup)
    {
        Amount = capturedGroup.TrimStart('-');
        Factor = capturedGroup.StartsWith('-') ? -1 : 1;
    }

    public int SubstituteUnknown(int i)
    {
        var replacedString = Amount.Replace("?", i.ToString());
        return int.Parse(replacedString) * Factor;
    }
}