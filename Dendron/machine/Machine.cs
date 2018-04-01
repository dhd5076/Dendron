using System;
using System.Collections.Generic;
using System.Text;

namespace Dendron.machine
{
    class Machine
    {
        private static Dictionary<String, int> variableTable;
        private static Stack<int> stack;

        public interface Instruction
        {
            void execute();
        }

        public class Print : Instruction
        {
            void Instruction.execute()
            {
                Console.WriteLine();
            }
        }

        public class Multiply : Instruction
        {
            void Instruction.execute()
            {
                int rhsOP = stack.Pop();
                int lhsOP = stack.Pop();
                stack.Push(lhsOP * rhsOP);
            }
        }
    }
}
