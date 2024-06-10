using System.Diagnostics;

namespace FunctionGenerator.Tokens
{
    [DebuggerDisplay("Identifier: {Value}")]
    public class IdentifierToken(string value)
        : IToken
    {
        public string Value => value;
    }
}