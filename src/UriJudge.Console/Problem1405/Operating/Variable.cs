namespace UriJudge.Console.Problem1405.Operating
{
    /// <summary>
    /// Representa um operando com valor variável
    /// </summary>
    public class Variable : IOperating
    {
        public int Index { get; private set; }
        
        public Variable(int index)
        {
            Index = index;
        }

        public int GetValue(Program program)
        {
            return program.ReadVar(Index);
        }
    }
}
