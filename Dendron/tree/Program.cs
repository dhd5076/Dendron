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
            var ret = new List<Machine.IInstruction>();
            foreach(var node in _nodeList)
            {
                ret.AddRange(node.Emit());
            }
            return ret;
        }

        public void AddAction(IDendronNode node)
        {
            this._nodeList.Add(node);
        }
    }
}
