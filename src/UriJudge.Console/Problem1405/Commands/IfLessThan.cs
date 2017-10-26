namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFL
    /// </summary>
    public class IfLessThan : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) < OperatingB.GetValue(program);
        }
    }
}
