using System.Collections.Generic;
using System.Text;
using UriJudge.Console.Problem1405.Commands;
using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405
{
    /// <summary>
    /// Contexto de execução do programa
    /// </summary>
    public class Program
    {
        public static StringBuilder halting = new StringBuilder();

        /// <summary>
        /// Lista de comandos que compõem o programa
        /// </summary>
        private readonly ICollection<Command> _commands;

        /// <summary>
        /// Variáveis do programa
        /// </summary>
        private readonly int[] _variables;

        public Program(ICollection<Command> commands)
        {
            _commands = commands;
            _variables = new int[10];
        }

        /// <summary>
        /// Inicia a execução do programa, e retorna o valor calculado
        /// </summary>
        /// <param name="r0">Parâmetro de entrada</param>
        /// <returns>O valor calculado pelo programa</returns>
        public int Start(int r0)
        {
            _variables[0] = r0;
            //_commands.ExecuteAll(this);

            var count = 1;
            foreach (var c in _commands)
            {
                if (c is Call)
                {
                    halting.AppendFormat("\"{0} ->  Call {1}\"\n", r0, count);
                }

                if (!c.Execute(this))
                    break;

                count++;
            }

            return _variables[9];
        }

        /// <summary>
        /// Atualiza o valor de uma variável
        /// </summary>
        /// <param name="index">Índice/Endereço da variável</param>
        /// <param name="value">Novo valor</param>
        public void WriteVar(Variable var, int value)
        {
            _variables[var.Index] = CheckOverflow(value);
        }

        /// <summary>
        /// Define o valor da variável de retorno (R9)
        /// </summary>
        /// <param name="value">Novo valor para R9</param>
        public void SetReturnValue(int value)
        {
            _variables[9] = CheckOverflow(value);
        }

        /// <summary>
        /// Efetua a leitura de uma variável
        /// </summary>
        /// <param name="index">Índice/Endereço da variável</param>
        /// <returns>O valor atual da variável</returns>
        public int ReadVar(int index)
        {
            return _variables[index];
        }

        /// <summary>
        /// Cria um novo contexto de execução do programa
        /// </summary>
        /// <returns>Novo programa, com novo contexto de variáveis</returns>
        public Program Clone()
        {
            return new Program(_commands);
        }

        /// <summary>
        /// Impede que os valores atribuidos às variáveis ultrapassem os limites suportados pela linguagem (0 até 999)
        /// </summary>
        /// <param name="value">Valor para checagem</param>
        /// <returns>Valor resolvido</returns>
        private int CheckOverflow(int value)
        {
            const int MOD = 1000;
            return (value % MOD + MOD) % MOD;
        }
    }
}
