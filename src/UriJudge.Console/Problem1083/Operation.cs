namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Representa uma operação na expressão algébrica
    /// </summary>
    public class Operation : Node
    {
        private readonly string _operatorSymbol;

        public Operation(string operatorSymbol)
        {
            _operatorSymbol = operatorSymbol;
        }

        /// <summary>
        /// Nó a esquerda
        /// </summary>
        public Node Left { get; set; }

        /// <summary>
        /// Nó a direita
        /// </summary>
        public Node Right { get; set; }

        /// <inheritdoc />
        public override string ToPostFix()
        {
            return string.Concat(Left.ToPostFix(), Right.ToPostFix(), _operatorSymbol);
        }
    }
}
