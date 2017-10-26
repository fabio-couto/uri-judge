namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando IFEQ
    /// </summary>
    public class IfEquals : IfCommand
    {
        public override bool CheckCondition(Program program)
        {
            return OperatingA.GetValue(program) == OperatingB.GetValue(program);
        }
    }
}
