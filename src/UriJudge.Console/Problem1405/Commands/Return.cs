using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando RET
    /// </summary>
    public class Return : Command
    {
        public IOperating Operating { get; set; }

        public override bool Execute(Program program)
        {
            program.SetReturnValue(Operating.GetValue(program));
            return false;
        }
    }
}
