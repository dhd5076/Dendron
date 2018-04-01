using Dendron.machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dendron.tree
{
    internal class Parser
    {
        readonly Program _program;
        public Parser(IEnumerable<string> tokens)
        {
            _program = new Program();
            var operandStack = new Stack<string>();
            var operatorStack = new Stack<string>();
            var pendingOperand = false;
            //Based on the pseudocode from the wikipedia page on polish notation
            foreach (var token in tokens)
            {
                if (token == "@") //If it is a an operator
                {
                    operatorStack.Push(token);
                    pendingOperand = false;
                }
                else if (token == "1") //If it is an operand
                {
                    operandStack.Push(token);

                }
            }
        }

        public List<Machine.Instruction> Compile()
        {
            return _program.Emit();
        }
    }
}
