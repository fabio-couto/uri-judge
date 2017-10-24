using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando ADD
    /// </summary>
    public class Add : Command
    {
        public Variable OperatingA;
        public IOperating OperatingB;

        public override void Execute(Program program)
        {
            program.WriteVar(OperatingA, OperatingA.GetValue() + OperatingB.GetValue());
        }
    }
}
