namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Tipos de token reconhecidos pelo analisador léxico
    /// </summary>
    public enum TokenType
    {
        Operating,
        Sum,
        Sub,
        Mul,
        Div,
        OpenParentheses,
        CloseParentheses,
        Exp,
        And,
        Or,
        GraterThan,
        LessThan,
        Equals,
        Sharp,
        Empty
    }
}
