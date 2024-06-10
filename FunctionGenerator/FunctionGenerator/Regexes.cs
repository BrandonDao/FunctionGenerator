using System.Text.RegularExpressions;

namespace FunctionGenerator
{
    public partial class Program
    {
        public partial class Regexes
        {
            [GeneratedRegex("^ *([a-zA-Z_][[a-zA-Z0-9_]*)", RegexOptions.Compiled)]
            public static partial Regex Identifier();

            [GeneratedRegex("^ *([-*+/])", RegexOptions.Compiled)]
            public static partial Regex Operator();

            [GeneratedRegex("^ *(\\()", RegexOptions.Compiled)]
            public static partial Regex OpenParenthesis();

            [GeneratedRegex("^ *(\\))", RegexOptions.Compiled)]
            public static partial Regex CloseParenthesis();

            [GeneratedRegex("^ *([0-9]+)", RegexOptions.Compiled)]
            public static partial Regex Literal();
        }
    }
}