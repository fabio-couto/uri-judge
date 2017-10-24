using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem1083;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1083Test
    {
        [TestMethod]
        public void TestLexicalError()
        {
            Assert.AreEqual("Lexical Error!", LEXSIM.ToPostFix("(A+B)*%"));
            Assert.AreEqual("Lexical Error!", LEXSIM.ToPostFix("(\"a+b*cc)/2*(e+a)"));
        }

        [TestMethod]
        public void TestSyntaxError()
        {
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("("));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(A+"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(a+b*c)/2*(e+a"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(ab+*c)/2*(e+a)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(a+b*cc)/2*(e+a"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(a + b)(c + d)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(a + b)(+c + d)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("a(+b)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("((a +)(b))"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("()"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("b)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("a)+(b"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("aa + b"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(a)(b)"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("(1 + 2)c"));
            Assert.AreEqual("Syntax Error!", LEXSIM.ToPostFix("()"));
        }

        [TestMethod]
        public void TestPostFixConversions()
        {
            Assert.AreEqual("AB+c*", LEXSIM.ToPostFix("(A+B)*c"));
            Assert.AreEqual("abc*+2/e*a+", LEXSIM.ToPostFix("(a+b*c)/2*e+a"));
            Assert.AreEqual("abc*+2/ea+*", LEXSIM.ToPostFix("(a+b*c)/2*(e+a)"));
            Assert.AreEqual("ab+c-", LEXSIM.ToPostFix("a+b-c"));
            Assert.AreEqual("abc*d/-e+", LEXSIM.ToPostFix("a-b*c/d+e"));
            Assert.AreEqual("ABC*+D+", LEXSIM.ToPostFix("A+B*C+D"));
            Assert.AreEqual("AB+CD+*", LEXSIM.ToPostFix("(A+B)*(C+D)"));
            Assert.AreEqual("AB*CD*+", LEXSIM.ToPostFix("A*B+C*D"));
            Assert.AreEqual("AB+C+D+", LEXSIM.ToPostFix("A+B+C+D"));
            Assert.AreEqual("1", LEXSIM.ToPostFix("1"));
        }
    }
}
