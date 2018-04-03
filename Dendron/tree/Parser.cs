using Dendron.machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dendron.tree
{
    internal class Parser
    {
        readonly Program _program;
        public Parser(IEnumerable<string> lines)
        {
            _program = new Program();
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
            //Adapted from the pseudocode on the polish notation wikipedia page
            var operationStack = new Stack<IDendronNode>();
            var operandStack = new Stack<IDendronNode>();
            foreach (var token in expressionTokens)
            {
                if(Regex.IsMatch(token, @"^\d+$"))
                {
                    operandStack.Push(new Constant(int.Parse(token)));
                }
            }

            return operationStack.Pop();
        }

        public List<Machine.IInstruction> Compile()
        {
            return _program.Emit();
        }
    }
}
