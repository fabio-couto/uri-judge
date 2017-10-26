using System;

namespace UriJudge.Console.Problem1405
{
    /// <summary>
    /// Exceção para os casos de detecção de looping infinito
    /// </summary>
    public class InfiniteLoopException : Exception
    {
        public InfiniteLoopException(string message = "Infinite loop, the program won't stop")
            : base(message)
        {
        }
    }
}
