using System.Collections.Generic;

namespace UnknownDigit;

public class Expression
{
    public ExpressionValue Operand1 { get; set; }
    public ExpressionValue Operand2 { get; set; }
    public ExpressionValue Result { get; set; }
    public string Operator { get; set; }
    public IEnumerable<int> IncludedNumbers { get; set; }
}