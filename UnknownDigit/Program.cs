using System;
using UnknownDigit;

const string expression = "123*45?=5?088";
var result = UnknownDigitFinder.SolveExpression(expression);

Console.WriteLine(result);