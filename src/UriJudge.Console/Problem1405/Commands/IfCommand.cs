using System.Collections.Generic;
using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Classe base para comandos condicionais (IF)
    /// </summary>
    public abstract class IfCommand : Command
    {
        public IOperating OperatingA { get; set; }
        public IOperating OperatingB { get; set; }
        public ICollection<Command> Commands { get; set; }

        public IfCommand()
        {
            Commands = new List<Command>();
        }

        public override bool Execute(Program program)
        {
            if (CheckCondition(program))
                return Commands.ExecuteAll(program);

            return true;
        }

        public abstract bool CheckCondition(Program program);
    }
}
