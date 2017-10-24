using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Text;
using UriJudge.Console.Problem1405;
using UriJudge.Console.Problem1405.Commands;
using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Tests
{
    [TestClass]
    public class Problem1405Tests
    {
        [TestMethod]
        public void Test()
        {
            //var program = new StringBuilder();
            //program.AppendLine("IFEQ R0,0");
            //program.AppendLine("RET 1");
            //program.AppendLine("ENDIF");
            //program.AppendLine("MOV R1,R0");
            //program.AppendLine("SUB R1,1");
            //program.AppendLine("CALL R1");
            //program.AppendLine("MOV R2, R9");
            //program.AppendLine("MUL R2, R0");
            //program.AppendLine("RET R2");

            var p = new Program();

            Program.Commands.Add(new Add { OperatingA = new Variable(p, 0), OperatingB = new Constant(5) });
            Program.Commands.Add(new Return { Operating = new Variable(p, 0) });

            var result = p.Execute(5);
            

        }
    }
}
