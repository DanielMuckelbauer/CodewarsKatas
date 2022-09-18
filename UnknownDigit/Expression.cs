using System.Collections.Generic;

namespace UnknownDigit;

public class Expression
{
    public string Operand1 { get; set; }
    public string Operator { get; set; }
    public string Operand2 { get; set; }
    public string Result { get; set; }
    public IEnumerable<int> Operand1UnknownIndices { get; set; }
    public IEnumerable<int> Operand2UnknownIndices { get; set; }
    public IEnumerable<int> ResultUnknownIndices { get; set; }
}