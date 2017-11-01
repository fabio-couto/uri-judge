using System;
using System.Collections.Generic;
using System.IO;
using UriJudge.Console.Problem1405.Commands;
using UriJudge.Console.Problem1405.Operating;

namespace UriJudge.Console.Problem1405
{
    /// <summary>
    /// Parser para os programas
    /// </summary>
    public static class Parser
    {
        private static readonly IDictionary<string, IOperating> _cache = new Dictionary<string, IOperating>();

        /// <summary>
        /// Converte a string em um objeto Program
        /// O Parser não efetua análise léxica e sintática, ou seja, ele espera programas sintaticamente corretos
        /// </summary>
        /// <param name="program">Instruções do programa em modo texto</param>
        /// <returns>Instância do programa</returns>
        public static Program Parse(string program)
        {
            using (var reader = new StringReader(program))
            {
                var line = string.Empty;
                var ifs = new Stack<IfCommand>();
                var commands = new List<Command>();

                while ((line = reader.ReadLine()) != null)
                {
                    var command = CreateCommand(ParseCommandLine(line));

                    //Trata o aninhamento dos IFs
                    if (command != null)
                    {
                        if (ifs.Count == 0)
                            commands.Add(command);
                        else
                            ifs.Peek().Commands.Add(command);

                        var if_cmd = command as IfCommand;
                        if (if_cmd != null)
                            ifs.Push(if_cmd);
                    }
                    else //ENDIF
                    {
                        ifs.Pop();
                    }
                }

                return new Program(commands, new Dictionary<int, int?>());
            }
        }

        /// <summary>
        /// Efetua o parsing da linha de comando
        /// </summary>
        /// <param name="line">Linha de comando</param>
        /// <returns>Comando estruturado</returns>
        private static CommandStructure ParseCommandLine(string line)
        {
            //Simulação de um automato finito regular
            var commandName = string.Empty;
            var operatingA = string.Empty;
            var operatingB = string.Empty;

            //1 - Leitura do Comando 
            //2 - Leitura do Operando 1 
            //3 - Leitura do Operando 2
            byte state = 1;

            foreach (var c in line)
            {
                switch (state)
                {
                    case 1:
                        if (char.IsWhiteSpace(c) && commandName.Length > 0)
                            state = 2;
                        else if (!char.IsWhiteSpace(c))
                            commandName += c;
                        break;

                    case 2:
                        if (c == ',')
                            state = 3;
                        else if (!char.IsWhiteSpace(c))
                            operatingA += c;
                        break;

                    case 3:
                        if (!char.IsWhiteSpace(c))
                            operatingB += c;
                        break;
                }
            }

            return new CommandStructure
            {
                CommandName = commandName,
                OperatingA = operatingA,
                OperatingB = operatingB
            };
        }

        /// <summary>
        /// Cria a instância de execução do comando a partir da estrutura
        /// </summary>
        /// <param name="structure">Estrutura do comando</param>
        /// <returns>Instância para execução do comando</returns>
        private static Command CreateCommand(CommandStructure structure)
        {
            var opA = GetOperating(structure.OperatingA);
            var opB = GetOperating(structure.OperatingB);

            switch (structure.CommandName)
            {
                case "MOV":
                    return new Assign { OperatingA = (Variable)opA, OperatingB = opB };
                case "ADD":
                    return new Addition { OperatingA = (Variable)opA, OperatingB = opB };
                case "SUB":
                    return new Subtraction { OperatingA = (Variable)opA, OperatingB = opB };
                case "MUL":
                    return new Multiplication { OperatingA = (Variable)opA, OperatingB = opB };
                case "DIV":
                    return new Division { OperatingA = (Variable)opA, OperatingB = opB };
                case "MOD":
                    return new Mod { OperatingA = (Variable)opA, OperatingB = opB };
                case "CALL":
                    return new Call { Operating = opA };
                case "RET":
                    return new Return { Operating = opA };
                case "IFEQ":
                    return new IfEquals { OperatingA = opA, OperatingB = opB };
                case "IFNEQ":
                    return new IfNotEquals { OperatingA = opA, OperatingB = opB };
                case "IFG":
                    return new IfGreaterThan { OperatingA = opA, OperatingB = opB };
                case "IFL":
                    return new IfLessThan { OperatingA = opA, OperatingB = opB };
                case "IFGE":
                    return new IfGreaterOrEqualsThan { OperatingA = opA, OperatingB = opB };
                case "IFLE":
                    return new IfLessOrEqualsThan { OperatingA = opA, OperatingB = opB };
                case "ENDIF":
                    return null;
                default:
                    throw new Exception(string.Format("Invalid command \"{0}\"", structure.CommandName));
            }

        }

        /// <summary>
        /// Retorna a instância da classe que representará o operador
        /// </summary>
        /// <param name="id">Identificador do operador</param>
        /// <returns>Instância do operador (Variável ou Constante)</returns>
        private static IOperating GetOperating(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            if (!_cache.ContainsKey(id))
            {
                IOperating obj;
                if (id.StartsWith("R"))
                    obj = new Variable(Convert.ToInt32(id[1].ToString()));
                else
                    obj = new Constant(Convert.ToInt32(id));

                _cache.Add(id, obj);
            }

            return _cache[id];
        }

        /// <summary>
        /// Estrutura básica dos comandos suportados pela linguagem
        /// </summary>
        private class CommandStructure
        {
            public string CommandName { get; set; }
            public string OperatingA { get; set; }
            public string OperatingB { get; set; }
        }
    }
}
