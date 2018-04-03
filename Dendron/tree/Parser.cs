using Dendron.machine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dendron.tree
{
    internal class Parser
    {
        readonly Program _program;
        public Parser(IEnumerable<string> lines)
        {
            _program = new Program();
            //Adapted from the pseudocode on the polish notation wikipedia page
            foreach (var line in lines)
            {
                var lineTokens = line.Split(' ');
                switch (lineTokens[0])
                {
                    case "@":
                        _program.AddAction(new Print(ParseExpression(lineTokens.Skip(1))));
                        break;
                    default:
                        break;
                }
            }
        }

        public IDendronNode ParseExpression(IEnumerable<string> expressionTokens)
        {
            foreach(var token in expressionTokens)
            {

            }

            return null;
        }

        public List<Machine.IInstruction> Compile()
        {
            return _program.Emit();
        }
    }
}
