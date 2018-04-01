using System;
using System.Collections.Generic;
using System.Text;
using Dendron.machine;

namespace Dendron.tree
{
    internal class Print : IDendronNode
    {
        private readonly IDendronNode _printee;

        public Print(IDendronNode printee)
        {
            this._printee = printee;
        }

        public List<Machine.Instruction> Emit()
        {
            var ret = new List<Machine.Instruction>
            {
                _printee.Emit()[0],
                new Machine.Print()
            };
            return ret;
        }
    }
}
