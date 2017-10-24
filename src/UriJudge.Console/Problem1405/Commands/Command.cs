namespace UriJudge.Console.Problem1405.Commands
{
    /// <summary>
    /// Classe base para todos os comandos reconhecidos pelo programa
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute(Program program);
    }
}
