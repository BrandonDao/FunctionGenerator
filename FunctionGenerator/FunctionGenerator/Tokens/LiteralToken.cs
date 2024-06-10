using System.Diagnostics;

namespace FunctionGenerator.Tokens
{
    [DebuggerDisplay("Literal: {Value}")]
    public class LiteralToken(string value)
        : IToken
    {
        public string Value => value;
    }
}