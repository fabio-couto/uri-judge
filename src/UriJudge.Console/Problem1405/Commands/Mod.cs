using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando MOD
    /// </summary>
    public class Mod : Command
    {
        public Variable OperatingA { get; set; }
        public IOperating OperatingB { get; set; }

        public override bool Execute(Program program)
        {
            int result;
            if (OperatingB.GetValue(program) == 0)
                result = 0;
            else
                result = OperatingA.GetValue(program) % OperatingB.GetValue(program);

            program.WriteVar(OperatingA, result);
            return true;
        }
    }
}
