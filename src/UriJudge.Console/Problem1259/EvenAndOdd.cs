using System.Collections.Generic;
using System.Linq;

namespace UriJudge.Console.Problem1259
{
    /// <summary>
    /// URI Online Judge | 1259 | Pares e Ímpares
    /// </summary>
    public static class EvenAndOdd
    {
        public static int[] Sort(IEnumerable<int> input)
        {
            return input
                .Where(i => i % 2 == 0)
                .OrderBy(i => i)
                .Concat(
                    input
                    .Where(i => i % 2 != 0)
                    .OrderByDescending(i => i)
                ).ToArray();
        }
    }
}
