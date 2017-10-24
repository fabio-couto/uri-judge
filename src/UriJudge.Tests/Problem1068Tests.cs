using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1068;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1068Tests
    {
        [TestMethod]
        public void TestBalance()
        {
            Assert.AreEqual("correct", BalanceParentheses.Check("a+(b*c)-2-a"));
            Assert.AreEqual("correct", BalanceParentheses.Check("(a+b*(2-c)-2+a)*2"));
            Assert.AreEqual("incorrect", BalanceParentheses.Check("(a*b-(2+c)"));
            Assert.AreEqual("incorrect", BalanceParentheses.Check("2*(3-a))"));
            Assert.AreEqual("incorrect", BalanceParentheses.Check(")3+b*(2-c)("));
        }
    }
}
