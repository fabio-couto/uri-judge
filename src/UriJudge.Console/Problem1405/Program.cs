using System.Collections.Generic;
using UriJudge.Console.Problem1405.Commands;
using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405
{
    /// <summary>
    /// Contexto de execução do programa
    /// </summary>
    public class Program
    {
        private readonly ICollection<Command> _commands = new List<Command>();
        private readonly int[] _variables = new int[10];

        private bool _return = false;

        /// <summary>
        /// Executa o programa, e retorna o valor calculado
        /// </summary>
        /// <param name="r0">Parâmetro de entrada</param>
        /// <returns>O valor calculado pelo programa</returns>
        public int Execute(int r0)
        {
            _variables[0] = r0;

            foreach (var cmd in _commands)
            {
                cmd.Execute(this);

                if (_return)
                    break;
            }

            return _variables[9];
        }

        /// <summary>
        /// Atualiza o valor de uma variável do programa
        /// </summary>
        /// <param name="index">Índice/Endereço da variável</param>
        /// <param name="value">Novo valor</param>
        public void WriteVar(Variable var, int value)
        {
            _variables[var.GetIndex()] = value;
        }

        /// <summary>
        /// Efetua a leitura do valor de uma variável do programa
        /// </summary>
        /// <param name="index">Índice/Endereço da variável</param>
        /// <returns>O valor atual da variável</returns>
        public int ReadVar(int index)
        {
            return _variables[index];
        }

        /// <summary>
        /// Define o valor da variável de retorno (R9)
        /// </summary>
        /// <param name="value">Novo valor para R9</param>
        /// <param name="ret">Determina se o programa deve parar a execução e retornar valor para o método Execute</param>
        public void SetReturnValue(int value, bool ret)
        {
            _variables[9] = value;
            _return = ret;
        }
    }
}
