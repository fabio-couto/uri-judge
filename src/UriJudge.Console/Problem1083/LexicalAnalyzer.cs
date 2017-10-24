namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Analisador léxico
    /// </summary>
    public class LexicalAnalyzer
    {
        private readonly string _tape;
        private int _curPosition;

        public LexicalAnalyzer(string input)
        {
            _tape = input;
            _curPosition = 0;
        }

        /// <summary>
        /// Verifica se a leitura da fita chegou ao fim
        /// </summary>
        /// <returns>True se a leitura chegou ao fim, caso contrário, False</returns>
        public bool EOF()
        {
            return _curPosition >= _tape.Length;
        }

        /// <summary>
        /// Efetua a leitura do próximo token da fita, e avança o cursor de leitura
        /// </summary>
        /// <returns>Token</returns>
        public Token Scan()
        {
            while (!EOF())
            {
                var c = _tape[_curPosition++];

                if (char.IsWhiteSpace(c))
                    continue;

                if (char.IsLetterOrDigit(c))
                    return new Token { Value = c.ToString(), Type = TokenType.Operating };

                switch (c)
                {
                    case '+': return new Token { Value = c.ToString(), Type = TokenType.Sum };
                    case '-': return new Token { Value = c.ToString(), Type = TokenType.Sub };
                    case '*': return new Token { Value = c.ToString(), Type = TokenType.Mul };
                    case '/': return new Token { Value = c.ToString(), Type = TokenType.Div };
                    case '^': return new Token { Value = c.ToString(), Type = TokenType.Exp };
                    case '|': return new Token { Value = c.ToString(), Type = TokenType.Or };
                    case '.': return new Token { Value = c.ToString(), Type = TokenType.And };
                    case '(': return new Token { Value = c.ToString(), Type = TokenType.OpenParentheses };
                    case ')': return new Token { Value = c.ToString(), Type = TokenType.CloseParentheses };
                    case '#': return new Token { Value = c.ToString(), Type = TokenType.Sharp };
                    case '=': return new Token { Value = c.ToString(), Type = TokenType.Equals };
                    case '>': return new Token { Value = c.ToString(), Type = TokenType.GraterThan };
                    case '<': return new Token { Value = c.ToString(), Type = TokenType.LessThan };
                }

                throw new LexicalException();
            }

            return new Token { Value = null, Type = TokenType.Empty };
        }

        /// <summary>
        /// Efetua a leitura do próximo token da fita, sem avançar o cursor de leitura
        /// </summary>
        /// <returns>Token</returns>
        public Token Peek()
        {
            var pos = _curPosition;
            var token = Scan();
            _curPosition = pos;
            return token;
        }
    }
}
