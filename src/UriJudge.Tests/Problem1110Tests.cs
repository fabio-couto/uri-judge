using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1110;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1110Tests
    {
        [TestMethod]
        public void TestCardThrow()
        {
            Assert.AreEqual("Discarded cards: 1, 3, 5, 7, 4, 2\nRemaining card: 6", ThrowingCardsAway.Start(7));
            Assert.AreEqual("Discarded cards: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 4, 8, 12, 16, 2, 10, 18, 14\nRemaining card: 6", ThrowingCardsAway.Start(19));
            Assert.AreEqual("Discarded cards: 1, 3, 5, 7, 9, 2, 6, 10, 8\nRemaining card: 4", ThrowingCardsAway.Start(10));
            Assert.AreEqual("Discarded cards: 1, 3, 5, 2, 6\nRemaining card: 4", ThrowingCardsAway.Start(6));
        }
    }
}
