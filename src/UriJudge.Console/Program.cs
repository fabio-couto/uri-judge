namespace UriJudge.Console
{
    using Problem1405;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    class URI
    {
        static void Main(string[] args)
        {
            var output = new List<string>();

            var file = new StreamReader(@"C:\Users\Fábio\Desktop\parada.in");

            do
            {
                var input = file.ReadLine().Split(' ');
                var l = int.Parse(input[0]);
                var n = int.Parse(input[1]);

                if (l == 0 && n == 0)
                    break;

                var program = new StringBuilder();

                while (l > 0)
                {
                    program.AppendLine(file.ReadLine());
                    l--;
                }

                var p = Parser.Parse(program.ToString());

                try
                {
                    Program.halting.Clear();
                    output.Add(p.Start(n).ToString());
                }
                catch (InfiniteLoopException)
                {
                    output.Add("*");
                }

            } while (true);

            output.ForEach(x =>
            {
                Debug.WriteLine(x);
                Console.WriteLine(x);
            });
        }
    }
}
