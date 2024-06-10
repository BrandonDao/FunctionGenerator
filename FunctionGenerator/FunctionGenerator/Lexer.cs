using FunctionGenerator.Tokens;
using System.Text.RegularExpressions;

namespace FunctionGenerator
{
    public partial class Program
    {
        public static class Lexer
        {
            private static readonly Dictionary<Regex, Func<string, IToken>> TokenCtorByRegex = new()
            {
                [Regexes.Identifier()] = (val) => new IdentifierToken(val)
              , [Regexes.Operator()] = (val) => new OperatorToken(val)
              , [Regexes.OpenParenthesis()] = (val) => new OpenParenthesisToken(val)
              , [Regexes.CloseParenthesis()] = (val) => new OpenParenthesisToken(val)
              , [Regexes.Literal()] = (val) => new LiteralToken(val)
            };

            public static List<IToken> Tokenize(string expression)
            {
                List<IToken> tokens = [];
                ReadOnlySpan<char> span = expression;

            regexMatchStart:
                while (!span.IsEmpty)
                {
                    foreach(Regex regex in TokenCtorByRegex.Keys)
                    {
                        Match match = regex.Match(span.ToString());

                        if (match.Success)
                        {
                            tokens.Add(TokenCtorByRegex[regex].Invoke(match.Groups[1].Value));

                            span = span[match.Length..];
                            goto regexMatchStart;
                        }
                    }
                    throw new InvalidOperationException("Could not match expression to token!");
                }

                return tokens;
            }


        }
    }
}