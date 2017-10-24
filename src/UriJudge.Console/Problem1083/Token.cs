namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Representa um token reconhecido pela linguagem
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Valor lido da fita de entrada
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Tipo do Token
        /// </summary>
        public TokenType Type { get; set; }
    }
}
