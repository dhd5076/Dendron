using Dendron.machine;
using Dendron.tree;
using System;
using System.Collections.Generic;

namespace Dendron
{
    internal class Program
    {
        private static List<Machine.Instruction> generatedInstructions;
        private static void Main(string[] args)
        {
            var tokens = new List<string>
            {
                "@",
                "1"
            };
            var parser = new Parser(tokens);
            generatedInstructions = parser.Compile();
        }
    }
}
