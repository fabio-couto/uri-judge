using System;
using System.Collections.Generic;

namespace UriJudge.Console.Problem1068
{
    /// <summary>
    /// URI Online Judge | 1068 | Balanço de Parênteses I
    /// </summary>
    public static class BalanceParentheses
    {
        /// <summary>
        /// Verifica se quantidade de parenteses na expressão está correta
        /// </summary>
        /// <param name="expression">Expressão algébrica</param>
        /// <returns>correct/incorrect</returns>
        public static string Check(string expression)
        {
            var stack = new Stack<char>();
            
            foreach (var c in expression)
            {
                if (c == '(')
                    stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return "incorrect";

                    stack.Pop();
                }
            }

            if (stack.Count > 0)
                return "incorrect";

            return "correct";
        }
    }
}
