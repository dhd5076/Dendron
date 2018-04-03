using Dendron.machine;
using Dendron.tree;
using System;
using System.Collections.Generic;

namespace Dendron
{
    internal class Program
    {
        private static List<Machine.IInstruction> _generatedInstructions;
        private static void Main(string[] args)
        {
            var tokens = new List<string>
            {
                "@ 1"
            };
            var parser = new Parser(tokens);
            _generatedInstructions = parser.Compile();
            foreach (var instruction in _generatedInstructions)
            {
                Console.WriteLine(instruction.ToString());
            }
            Console.ReadLine();
        }
    }
}
