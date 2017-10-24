using System;

namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Erro de análise sintática
    /// </summary>
    public class SyntaxException : Exception
    {
        public SyntaxException(string message = "Syntax Error!")
            : base(message)
        {
        }
    }
}
