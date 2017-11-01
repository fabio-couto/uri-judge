namespace UriJudge.Console
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class URI
    {
        static void Main(string[] args)
        {
            var output = new List<string>();

            do
            {
                var input = Console.ReadLine().Split(' ');
                var l = int.Parse(input[0]);
                var n = int.Parse(input[1]);

                if (l == 0 && n == 0)
                    break;

                

            } while (true);

            output.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}