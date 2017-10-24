using System.Collections.Generic;

namespace UriJudge.Console.Problem2671
{
    /// <summary>
    /// URI Online Judge | 2671 | Decodificando o Texto
    /// </summary>
    public static class BinaryTreeEncoder
    {
        /// <summary>
        /// Decodifica o texto
        /// </summary>
        /// <param name="encodedText">Texto codificado</param>
        /// <returns>Texto original</returns>
        public static string Decode(string encodedText)
        {
            if (string.IsNullOrEmpty(encodedText))
                return encodedText;

            var originalText = new char?[encodedText.Length];
            var readPosition = 0;

            //Efetua uma busca em profundidade
            var stack = new Stack<int>();
            stack.Push(0);

            while (stack.Count > 0)
            {
                var currentNode = stack.Peek();

                var leftNode = 2 * currentNode + 1;
                var rightNode = 2 * currentNode + 2;

                if (leftNode < originalText.Length && originalText[leftNode] == null)
                {
                    stack.Push(leftNode);
                }
                else
                {
                    originalText[currentNode] = encodedText[readPosition++];
                    stack.Pop();

                    if (rightNode < originalText.Length && originalText[rightNode] == null)
                    {
                        stack.Push(rightNode);
                    }
                }
            }

            return string.Join(string.Empty, originalText);
        }
    }
}