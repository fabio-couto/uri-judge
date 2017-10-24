using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace UriJudge.Console.Problem1215
{
    /// <summary>
    /// URI Online Judge | 1215 | Primeiro Dicionário de Andy
    /// </summary>
    public static class AndyDictionary
    {
        public static SortedSet<string> Build(string text)
        {
            int? start = null;
            int lenght = 0;
            var words = new SortedSet<string>();

            if (text == null)
                return words;

            for (int i = 0; i <= text.Length; i++)
            {
                if (i < text.Length && ((text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122)))
                {
                    if (start == null)
                        start = i;

                    lenght++;
                }
                else if (lenght > 0 && start.HasValue)
                {
                    var word = text.Substring(start.Value, lenght).ToLower();
                    
                    if (!words.Contains(word))
                        words.Add(word);

                    lenght = 0;
                    start = null;
                }
            }

            return words;
        }
    }
}
