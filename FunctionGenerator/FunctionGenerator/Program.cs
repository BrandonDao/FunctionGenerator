namespace FunctionGenerator
{
    public partial class Program
    {
        private static void Main()
        {
            var tokens = Lexer.Tokenize("a + (b * 2) / (c - 1)");
        }
    }
}