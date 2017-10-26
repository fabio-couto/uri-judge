using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando MOV
    /// </summary>
    public class Assign : Command
    {
        public Variable OperatingA { get; set; }
        public IOperating OperatingB { get; set; }

        public override bool Execute(Program program)
        {
            program.WriteVar(OperatingA, OperatingB.GetValue(program));
            return true;
        }
    }
}
