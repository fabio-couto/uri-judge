using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1022;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1022Tests
    {
        [TestMethod]
        public void TestCalculation()
        {
            Assert.AreEqual("10/8 = 5/4", TdaRacional.Calc("1 / 2 + 3 / 4"));
            Assert.AreEqual("-2/8 = -1/4", TdaRacional.Calc("1 / 2 - 3 / 4"));
            Assert.AreEqual("12/18 = 2/3", TdaRacional.Calc("2 / 3 * 6 / 6"));
            Assert.AreEqual("4/6 = 2/3", TdaRacional.Calc("1 / 2 / 3 / 4"));
            Assert.AreEqual("4/4 = 1/1", TdaRacional.Calc("1 / 2 + 1 / 2"));
        }
    }
}
