namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFNEQ
    /// </summary>
    public class IfNotEquals : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) != OperatingB.GetValue(program);
        }
    }
}
