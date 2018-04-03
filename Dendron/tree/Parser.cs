using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Dendron.machine;

namespace Dendron.tree
{
    internal class Parser
    {
        private readonly Program _program;

        public Parser(IEnumerable<string> lines)
        {
            _program = new Program();
            foreach (var line in lines)
            {
                var lineTokens = line.Split(' ');
                _program.AddAction(Parse(lineTokens));
            }
        }

        public IDendronNode Parse(IEnumerable<string> expressionTokens)
        {
            var enumerable = expressionTokens.ToList();
            if (enumerable.First() == "@") //If its a print statement
            {
                return new Print(Parse(enumerable.Skip(1)));
            }

            if (Regex.IsMatch(enumerable.First(), @"^\d+$")) //If its an integer
            {
                return new Constant(int.Parse(enumerable.First()));
            }
            else
            {
                return null;
            }
        }

        public List<Machine.IInstruction> Compile()
        {
            return _program.Emit();
        }
    }
}