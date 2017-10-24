namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// URI Online Judge | 1083 | LEXSIM - Avaliador Lexico e Sintático
    /// </summary>
    public static class LEXSIM
    {
        /// <summary>
        /// Converte uma expressão na notação infixa para notação pós-fixa 
        /// </summary>
        /// <param name="infixExpression">Expressão infixa</param>
        /// <returns>Expressão pós-fixa</returns>
        public static string ToPostFix(string infixExpression)
        {
            try
            {
                var syntaxAnalyzer = new SyntacticAnalyzer();
                var root = syntaxAnalyzer.Parse(infixExpression);
                return root.ToPostFix();
            }
            catch (LexicalException ex)
            {
                return ex.Message;
            }
            catch (SyntaxException ex)
            {
                return ex.Message;
            }
        }
    }
}
