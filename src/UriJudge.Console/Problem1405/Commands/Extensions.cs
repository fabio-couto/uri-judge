using System.Collections.Generic;

namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Extensões para a coleção de comandos
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Executa a lista de comandos, respeitando o critério de parada no caso de retorno
        /// </summary>
        /// <param name="commands">Lista de comandos</param>
        /// <param name="program">Referência para o programa em execução</param>
        /// <returns>True se o fluxo de execução deve continuar, caso contrário, False</returns>
        public static bool ExecuteAll(this ICollection<Command> commands, Program program)
        {
            foreach (var cmd in commands)
            {
                var continueExecution = cmd.Execute(program);

                if (!continueExecution)
                    return false;
            }

            return true;
        }
    }
}
