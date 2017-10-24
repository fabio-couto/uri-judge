using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1259;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1259Tests
    {
        [TestMethod]
        public void TestEvenAndOddSort()
        {
            var result = EvenAndOdd.Sort(new[] { 4, 32, 34, 543, 3456, 654, 567, 87, 6789, 98 });
            var expected = new[] { 4, 32, 34, 98, 654, 3456, 6789, 567, 543, 87 };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
