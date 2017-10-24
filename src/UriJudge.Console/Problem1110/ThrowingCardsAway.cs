
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UriJudge.Console.Problem1110
{
    /// <summary>
    /// URI Online Judge | 1110 | Jogando Cartas Fora
    /// </summary>
    public static class ThrowingCardsAway
    {
        public static string Start(int n)
        {
            var stack = new List<int>(Enumerable.Range(1, n));
            var lstDiscarded = new List<int>();

            while (stack.Count > 1)
            {
                lstDiscarded.Add(stack[0]);
                stack.RemoveAt(0);

                var top = stack[0];
                stack.RemoveAt(0);
                stack.Add(top);
            }

            return string.Format("Discarded cards: {0}\nRemaining card: {1}", string.Join(", ", lstDiscarded), stack[0]);
        }
    }
}
