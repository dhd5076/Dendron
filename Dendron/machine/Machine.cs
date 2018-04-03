using System;
using System.Collections.Generic;
using System.Text;

namespace Dendron.machine
{
    internal class Machine
    {
        private Machine() { }

        private static Dictionary<string, int> _variableTable;
        private static Stack<int> _stack;

        private void Reset()
        {
            _stack = new Stack<int>();
            _variableTable = new Dictionary<string, int>();
        }

        public interface IInstruction
        {
            void Execute();
        }

        public class Print : IInstruction
        {
            void IInstruction.Execute()
            {
                Console.WriteLine("*** " + _stack.Pop());
            }
        }

        public class Multiply : IInstruction
        {
            void IInstruction.Execute()
            {
                throw new NotImplementedException();
                /*
                var rhsOpPop = _stack.Pop();
                var lhsOpPop = _stack.Pop();
                _stack.Push(lhsOpPop * rhsOpPop);
                */
            }
        }

        public class PushConstant : IInstruction
        {
            private readonly int _value;

            public PushConstant(int value)
            {
                this._value = value;
            }

            void IInstruction.Execute()
            {
                _stack.Push(this._value);
            }
        }
    }
}
