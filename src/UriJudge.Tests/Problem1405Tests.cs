using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using UriJudge.Console.Problem1405;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1405Test
    {
        [TestMethod]
        public void TestFatorial()
        {
            var program = new StringBuilder();
            program.AppendLine("IFEQ R0,0");
            program.AppendLine("    RET 1");
            program.AppendLine("ENDIF");
            program.AppendLine("MOV R1,R0");
            program.AppendLine("SUB R1,1");
            program.AppendLine("CALL R1");
            program.AppendLine("MOV R2, R9");
            program.AppendLine("MUL R2, R0");
            program.AppendLine("RET R2");

            var p = Parser.Parse(program.ToString());

            var result = p.Start(6);

            Assert.AreEqual(720, result);
        }

        [TestMethod]
        public void TestEvenOrOdd()
        {
            var program = new StringBuilder();
            program.AppendLine("MOV R1, R0");
            program.AppendLine("MOD R1, 2");
            program.AppendLine("IFEQ R1, 0");
            program.AppendLine("    RET 2");
            program.AppendLine("ENDIF");
            program.AppendLine("RET 1");

            var p = Parser.Parse(program.ToString());

            //Impares
            Assert.AreEqual(1, p.Start(131));
            Assert.AreEqual(1, p.Start(199));
            Assert.AreEqual(1, p.Start(27));
            Assert.AreEqual(1, p.Start(3));

            //Pares
            Assert.AreEqual(2, p.Start(0));
            Assert.AreEqual(2, p.Start(998));
            Assert.AreEqual(2, p.Start(500));
            Assert.AreEqual(2, p.Start(28));
        }

        [TestMethod]
        public void TestMultipleIfs()
        {
            var program = new StringBuilder();
            program.AppendLine("IFG R0, 500");
            program.AppendLine("    MOV R1, R0");
            program.AppendLine("    MOD R0, 2");
            program.AppendLine("    IFEQ R0, 0");
            program.AppendLine("        RET 1");
            program.AppendLine("    ENDIF");
            program.AppendLine("    SUB R1, 103");
            program.AppendLine("    RET R1");
            program.AppendLine("ENDIF");
            program.AppendLine("IFL R0, 500");
            program.AppendLine("    MOV R4, R0");
            program.AppendLine("    MOD R0, 2");
            program.AppendLine("    IFEQ R0, 0");
            program.AppendLine("        RET 3");
            program.AppendLine("    ENDIF");
            program.AppendLine("    ADD R4, 10");
            program.AppendLine("    RET R4");
            program.AppendLine("ENDIF");
            program.AppendLine("RET 5");

            var p = Parser.Parse(program.ToString());

            Assert.AreEqual(1, p.Start(600));
            Assert.AreEqual(600, p.Start(703));
            Assert.AreEqual(3, p.Start(400));
            Assert.AreEqual(23, p.Start(13));
            Assert.AreEqual(5, p.Start(500));
        }

        [TestMethod]
        public void TestVariableOverflow()
        {
            var program = new StringBuilder();
            program.AppendLine("MOV R1, R0");
            program.AppendLine("MOD R1, 2");
            program.AppendLine("IFEQ R1, 0");
            program.AppendLine("    ADD R0, 50");
            program.AppendLine("    RET R0");
            program.AppendLine("ENDIF");
            program.AppendLine("SUB R0, 65");
            program.AppendLine("RET R0");

            var p = Parser.Parse(program.ToString());

            Assert.AreEqual(52, p.Start(2));
            Assert.AreEqual(54, p.Start(4));
            Assert.AreEqual(950, p.Start(900));
            Assert.AreEqual(966, p.Start(916));
            Assert.AreEqual(6, p.Start(956));
            Assert.AreEqual(24, p.Start(974));
            Assert.AreEqual(32, p.Start(982));
            Assert.AreEqual(48, p.Start(998));
            Assert.AreEqual(936, p.Start(1));
            Assert.AreEqual(938, p.Start(3));
            Assert.AreEqual(940, p.Start(5));
            Assert.AreEqual(834, p.Start(899));
            Assert.AreEqual(850, p.Start(915));
            Assert.AreEqual(892, p.Start(957));
            Assert.AreEqual(908, p.Start(973));
            Assert.AreEqual(916, p.Start(981));
            Assert.AreEqual(934, p.Start(999));
        }

        [TestMethod]
        [ExpectedException(typeof(InfiniteLoopException))]
        public void TestInfiniteLoopDetection()
        {
            var program = new StringBuilder();
            program.AppendLine("CALL R0");
            program.AppendLine("RET R0");

            var p = Parser.Parse(program.ToString());

            p.Start(123);
        }

        [TestMethod]
        [ExpectedException(typeof(InfiniteLoopException))]
        public void TestInfiniteLoopDetection2()
        {
            var program = new StringBuilder();
            program.AppendLine("IFNEQ R0, 0");
            program.AppendLine("    SUB R0, 1");
            program.AppendLine("    CALL R0");
            program.AppendLine("ENDIF");
            program.AppendLine("CALL 999");
            program.AppendLine("RET R0");

            var p = Parser.Parse(program.ToString());

            p.Start(999);
        }

        [TestMethod]
        public void TesteFibonacci()
        {
            var program = new StringBuilder();
            program.AppendLine("IFLE R0,1");
            program.AppendLine("    RET R0");
            program.AppendLine("ENDIF");
            program.AppendLine("MOV R1,R0");
            program.AppendLine("SUB R1,1");
            program.AppendLine("CALL R1");
            program.AppendLine("MOV R3, R9");
            program.AppendLine("MOV R2, R0");
            program.AppendLine("SUB R2,2");
            program.AppendLine("CALL R2");
            program.AppendLine("ADD R3, R9");
            program.AppendLine("RET R3");

            var p = Parser.Parse(program.ToString());

            Assert.AreEqual(987, p.Start(16));
            Assert.AreEqual(867, p.Start(256));
        }
    }
}
