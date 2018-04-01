using Dendron.machine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dendron.tree
{
    internal interface IDendronNode
    {
        List<Machine.Instruction> Emit();
    }
}
