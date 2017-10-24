namespace UriJudge.Console.Problem1405.Operating
{
    /// <summary>
    /// Representa um operando com valor constante
    /// </summary>
    public class Constant : IOperating
    {
        private readonly int _value;

        public Constant(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}