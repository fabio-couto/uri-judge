using Microsoft.VisualStudio.TestTools.UnitTesting;
using UriJudge.Console.Problem2671;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem2671Tests
    {
        [TestMethod]
        public void TestDecode()
        {
            Assert.AreEqual(null, BinaryTreeEncoder.Decode(null));
            Assert.AreEqual(string.Empty, BinaryTreeEncoder.Decode(string.Empty));
            Assert.AreEqual("a", BinaryTreeEncoder.Decode("a"));
            Assert.AreEqual("Ab", BinaryTreeEncoder.Decode("bA"));
            Assert.AreEqual("AbC", BinaryTreeEncoder.Decode("bAC"));
            Assert.AreEqual("Um texto simples", BinaryTreeEncoder.Decode("sot mseiUmxp lte"));
            Assert.AreEqual("PROGBASE 2017", BinaryTreeEncoder.Decode("EG R2B0P1A7OS"));
            Assert.AreEqual("Um texto um pouco menos simples", BinaryTreeEncoder.Decode("coot  mmeuneomsU  sxipm polteus"));
            Assert.AreEqual("Um texto mais extenso, e mais complexo", BinaryTreeEncoder.Decode("oxmoptlteex onmsmoe,a Uei xmsa i st ec"));
            Assert.AreEqual("Ele supõe saber alguma coisa e não sabe, enquanto eu, se não sei, tampouco suponho saber parece que sou um pouco mais sábio que ele exatamente por não supor que saiba o que não sei.", BinaryTreeEncoder.Decode(" ienl,e   eãxtaõtaaommeanpt eo  puosrc lnoãao  essubpuogrp eqoulen ,shauiob a   os eqaumeb nneãsor qs eaip.uasrae cneE tqcuoea  sooeuu uuim, bp osusceoe am aeins  ãspáobei or sq uee"));
            Assert.AreEqual("Sim, sei de onde venho!Insatisfeito com a labareda ardo para me consumir!Aquilo em que toco torna-se luz.Carvão aquilo que abandono. Sou certamente labareda!", BinaryTreeEncoder.Decode("d oencoe.o iSnoius tcue rmtoaim,ern t!ev Alcaqb auroeideal!moi  enma dq uhel  taoocboe at!orrSneaI-ds ea nl usza.sCraordvaãoom  atqpunialior eqause  dambfaen"));
            Assert.AreEqual("E eu, que estou de bem com a vida, creio que aqueles que mais entendem de felicidade são as borboletas e as bolhas de sabão e tudo que entre os homens se lhes assemelhem", BinaryTreeEncoder.Decode("unddot  qeuaen uedn,terdem  o su dhcoemee nrsf eseee ll hieisc  aisosdebmae ldh eemq esuã,oe ma se ab oqrEbuocleestlaose  es ma st qb ouleheaas  odme  asqaibvãsou  ei et"));
        }
    }
}