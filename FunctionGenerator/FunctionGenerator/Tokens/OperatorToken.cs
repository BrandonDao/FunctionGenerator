using System.Diagnostics;

namespace FunctionGenerator.Tokens
{
    [DebuggerDisplay("Operator: {Value}")]
    public class OperatorToken(string value)
        : IToken
    {
        public string Value => value;
    }
}