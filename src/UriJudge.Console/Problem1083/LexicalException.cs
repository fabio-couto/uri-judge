using System;

namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Erro de análise léxica
    /// </summary>
    public class LexicalException : Exception
    {
        public LexicalException(string message = "Lexical Error!")
            : base(message)
        {
        }
    }
}
