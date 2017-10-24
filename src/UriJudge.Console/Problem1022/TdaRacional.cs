using System;

namespace UriJudge.Console.Problem1022
{
    /// <summary>
    /// URI Online Judge | 1022 | TDA Racional
    /// </summary>
    public static class TdaRacional
    {
        /// <summary>
        /// Resolve a expressão entre frações, e retorna o resultado calculado e simplificado
        /// </summary>
        /// <param name="input">Expressão no formato N1 / D1 y N2 / D2, onde y ∈ {+,-,/,*}</param>
        /// <returns>Expressão no formato N3/D3 = N4/D4, onde N4 e D4 estão simplificados</returns>
        public static string Calc(string input)
        {
            var arr = input.Split(' ');
            if (arr.Length != 7)
                throw new Exception("Invalid number of arguments");

            var n1 = int.Parse(arr[0]);
            var d1 = int.Parse(arr[2]);
            var op = arr[3];
            var n2 = int.Parse(arr[4]);
            var d2 = int.Parse(arr[6]);
            var n3 = 0;
            var d3 = 0;

            switch (op)
            {
                case "+":
                    n3 = n1 * d2 + n2 * d1;
                    d3 = d1 * d2;
                    break;

                case "-":
                    n3 = n1 * d2 - n2 * d1;
                    d3 = d1 * d2;
                    break;

                case "*":
                    n3 = n1 * n2;
                    d3 = d1 * d2;
                    break;

                case "/":
                    n3 = n1 * d2;
                    d3 = n2 * d1;
                    break;

                default:
                    throw new Exception(string.Format("Invalid operator {0}", op));
            }

            var mdc = Math.Abs(MDC(n3, d3));
            return string.Format("{0}/{1} = {2}/{3}", n3, d3, n3 / mdc, d3 / mdc);
        }

        /// <summary>
        /// Calcula o MDC utilizando o algoritmo de Euclides
        /// </summary>
        /// <param name="a">Número 1</param>
        /// <param name="b">Número 2</param>
        /// <returns>MDC</returns>
        private static int MDC(int a, int b)
        {
            if (b == 0)
                return a;

            return MDC(b, a % b);
        }
    }
}
