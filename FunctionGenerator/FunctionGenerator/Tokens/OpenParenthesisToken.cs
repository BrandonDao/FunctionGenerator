using System.Diagnostics;

namespace FunctionGenerator.Tokens
{
    [DebuggerDisplay("OpenParenthesis: {Value}")]
    public class OpenParenthesisToken(string value)
        : IToken
    {
        public string Value => value;
    }
}