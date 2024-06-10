using System.Diagnostics;

namespace FunctionGenerator.Tokens
{
    [DebuggerDisplay("CloseParenthesis: {Value}")]
    public class CloseParenthesisToken(string value)
        : IToken
    {
        public string Value => value;
    }
}