using System;
using System.Collections.Generic;
using System.Text;
using Dendron.machine;

namespace Dendron.tree
{
    internal class Program : IDendronNode
    {
        private readonly List<IDendronNode> _nodeList;

        public Program()
        {
            this._nodeList = new List<IDendronNode>();
        }

        public List<Machine.IInstruction> Emit()
        {
            throw new NotImplementedException();
        }

        public void AddAction(IDendronNode node)
        {
            this._nodeList.Add(node);
        }
    }
}
