using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UriJudge.Console.Problem1244
{
    /// <summary>
    /// URI Online Judge | 1244 | Ordenação por Tamanho 
    /// </summary>
    public static class SortBySize
    {
        public static IEnumerable<string> Sort(IEnumerable<string> input)
        {
            foreach (var s in input)
                yield return string.Join(" ", s.Split(' ').OrderByDescending(i => i.Length));
        }
    }
}
