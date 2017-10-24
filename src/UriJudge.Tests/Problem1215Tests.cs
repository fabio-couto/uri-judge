using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1215;
using UriJudge.Tests.Properties;
using System;
using System.Linq;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1215Tests
    {
        [TestMethod]
        public void TestAndyDictionaryText1()
        {
            var expected = Resources.AndyDictionaryWords1.Split(new [] { "\r\n" }, StringSplitOptions.None);
            
            CollectionAssert.AreEqual(expected, AndyDictionary.Build(Resources.AndyDictionaryText1));
        }

        [TestMethod]
        public void TestAndyDictionaryText2()
        {
            var expected = Resources.AndyDictionaryWords2.Split(new[] { "\r\n" }, StringSplitOptions.None);

            CollectionAssert.AreEqual(expected, AndyDictionary.Build(Resources.AndyDictionaryText2));
        }
    }
}
