using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1244;
using System.Linq;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1244Tests
    {
        [TestMethod]
        public void TestSortBySize()
        {
            var input = new[]
            {
                "Top Coder comp Wedn at midnight",
                "one three five",
                "I love Cpp",
                "sj a sa df r e w f d s a v c x z sd fd"
            };

            var expected = new[] {
                "midnight Coder comp Wedn Top at",
                "three five one",
                "love Cpp I",
                "sj sa df sd fd a r e w f d s a v c x z"
            };

            var result = SortBySize.Sort(input).ToArray();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
