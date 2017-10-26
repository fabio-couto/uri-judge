namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFLE
    /// </summary>
    public class IfLessOrEqualsThan : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) <= OperatingB.GetValue(program);
        }
    }
}
