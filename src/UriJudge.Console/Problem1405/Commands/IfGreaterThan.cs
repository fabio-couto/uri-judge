namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFG
    /// </summary>
    public class IfGreaterThan : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) > OperatingB.GetValue(program);
        }
    }
}
