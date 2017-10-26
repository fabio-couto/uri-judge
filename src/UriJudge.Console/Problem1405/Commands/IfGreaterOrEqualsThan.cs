namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFGE
    /// </summary>
    public class IfGreaterOrEqualsThan : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) >= OperatingB.GetValue(program);
        }
    }
}
