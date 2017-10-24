namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Classe base para os nós da árvore sintática
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// Monta a representação do nó algébrico em notação pós-fixa
        /// </summary>
        /// <returns>Notação pós-fixa</returns>
        public abstract string ToPostFix();
    }
}
