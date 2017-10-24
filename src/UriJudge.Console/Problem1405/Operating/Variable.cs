namespace UriJudge.Console.Problem1405.Operating
{
    /// <summary>
    /// Representa um operando com valor variável
    /// </summary>
    public class Variable : IOperating
    {
        private readonly Program _program;
        public readonly int _index;
        
        public Variable(Program program, int index)
        {
            _program = program;
            _index = index;
        }

        public int GetValue()
        {
            return _program.ReadVar(_index);
        }

        public int GetIndex()
        {
            return _index;
        }
    }
}
