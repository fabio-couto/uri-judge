﻿using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Implementação do comando SUB
    /// </summary>
    public class Subtraction : Command
    {
        public Variable OperatingA { get; set; }
        public IOperating OperatingB { get; set; }

        public override bool Execute(Program program)
        {
            var result = OperatingA.GetValue(program) - OperatingB.GetValue(program);
            program.WriteVar(OperatingA, result);
            return true;
        }
    }
}
