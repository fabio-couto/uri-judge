using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando CALL
    /// </summary>
    public class Call : Command
    {
        public IOperating Operating { get; set; }

        public override bool Execute(Program program)
        {
            var r0 = Operating.GetValue(program);
            var result = program.Clone().Start(r0);
            program.SetReturnValue(result);
            return true;
        }
    }
}
