using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando CALL
    /// </summary>
    public class Call : Command
    {
        public IOperating Operating;

        public override void Execute(Program program)
        {
            var result = new Program().Execute(Operating.GetValue());
            program.SetReturnValue(result, false);
        }
    }
}
