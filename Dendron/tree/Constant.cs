using System;
using System.Collections.Generic;
using System.Text;
using Dendron.machine;

namespace Dendron.tree
{
    internal class Constant : IDendronNode
    {
        private readonly int _value;

        public Constant(int value)
        {
            _value = value;
        }

        public List<Machine.IInstruction> Emit()
        {
            return new List<Machine.IInstruction>
            {
                new Machine.PushConstant(_value)
            };
        }
    }
}
