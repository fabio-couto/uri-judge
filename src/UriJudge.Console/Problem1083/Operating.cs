using System;

namespace UriJudge.Console.Problem1083
{
    /// <summary>
    /// Representa um operando na expressão algébrica
    /// </summary>
    public class Operating : Node
    {
        private readonly string _value;

        public Operating(string value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override string ToPostFix()
        {
            return Convert.ToString(_value);
        }
    }
}
