using System;

namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Analisador sintático LL(1) para expressões infixas (Top-down preditivo recursivo) 
    /// A  -> B A2
    /// A2 -> {|} B A2 | ɛ
    /// B  -> C B2
    /// B2 -> {.} C B2 | ɛ
    /// C  -> D C2
    /// C2 -> {>, &lt;, =, #} D C2 | ɛ
    /// D  -> E D2
    /// D2 -> {+, -} E D2 | ɛ
    /// E  -> F E2
    /// E2 -> {*. /} F E2 | ɛ
    /// F  -> G F2
    /// F2 -> {^} G F2 | ɛ
    /// G  -> {[a-Z][0-9]} | (A)
    /// </summary>
    public class SyntacticAnalyzer
    {
        private LexicalAnalyzer _lex;

        /// <summary>
        /// Monta a árvore sintática da expressão algébrica
        /// </summary>
        /// <param name="input">Expressão algébrica infixa</param>
        /// <returns>O nó raiz da árvore sintática</returns>
        public Node Parse(string input)
        {
            _lex = new LexicalAnalyzer(input);

            var root = A();

            if (!_lex.EOF())
                throw new SyntaxException();

            return root;
        }

        private Node A() { return A2(B(null)); }
        private Node B(Node left) { return B2(C(left)); }
        private Node C(Node left) { return C2(D(left)); }
        private Node D(Node left) { return D2(E(left)); }
        private Node E(Node left) { return E2(F(left)); }
        private Node F(Node left) { return F2(G()); }
        private Node A2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.Or)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = B(expr);
                return A2(expr);
            }

            return left;
        }
        private Node B2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.And)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = C(expr);
                return B2(expr);
            }

            return left;
        }
        private Node C2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.GraterThan || 
                token.Type == TokenType.LessThan || 
                token.Type == TokenType.Equals || 
                token.Type == TokenType.Sharp)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = D(expr);
                return C2(expr);
            }

            return left;
        }
        private Node D2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.Sum || 
                token.Type == TokenType.Sub)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = E(expr);
                return D2(expr);
            }

            return left;
        }
        private Node E2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.Mul ||
                token.Type == TokenType.Div)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = F(expr);
                return E2(expr);
            }

            return left;
        }
        private Node F2(Node left)
        {
            var token = _lex.Peek();

            if (token.Type == TokenType.Exp)
            {
                _lex.Scan();

                var expr = new Operation(token.Value);
                expr.Left = left;
                expr.Right = G();
                return F2(expr);
            }

            return left;
        }
        private Node G()
        {
            var token = _lex.Scan();

            if (token.Type == TokenType.Operating)
            {
                return new Operating(token.Value);
            }
            else if (token.Type == TokenType.OpenParentheses)
            {
                var a = A();
                token = _lex.Scan();
                if (token.Type == TokenType.CloseParentheses)
                    return a;
            }

            throw new SyntaxException();
        }
    }
}
