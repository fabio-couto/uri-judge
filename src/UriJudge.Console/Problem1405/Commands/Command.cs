namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Classe base para todos os comandos reconhecidos pelo programa
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// Executa a implementação do comando
        /// </summary>
        /// <param name="program">Referência para o contexto do programa em execução</param>
        /// <returns>True se a execução deve continuar, False em caso de fim de execução (Retorno)</returns>
        public abstract bool Execute(Program program);
    }
}
