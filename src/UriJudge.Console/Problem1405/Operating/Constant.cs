namespace UriJudge.Console.Problem1405.Operating
{
    /// <summary>
    /// Representa um operando com valor constante
    /// </summary>
    public class Constant : IOperating
    {
        public int Value { get; private set; }

        public Constant(int value)
        {
            Value = value;
        }

        public int GetValue(Program program)
        {
            return Value;
        }
    }
}