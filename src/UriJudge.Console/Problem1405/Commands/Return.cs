using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando RET
    /// </summary>
    public class Return : Command
    {
        public IOperating Operating;

        public override void Execute(Program program)
        {
            program.SetReturnValue(Operating.GetValue(), true);
        }
    }
}
